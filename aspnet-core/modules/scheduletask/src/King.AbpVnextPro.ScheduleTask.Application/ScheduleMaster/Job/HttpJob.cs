using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager;
using Quartz;
using Quartz.Impl.Triggers;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using King.AbpVnextPro.ScheduleTask.Schedules;
using System.Diagnostics;
using King.AbpVnextPro.Core.King.AbpVnextPro.Core;
using Volo.Abp.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using King.AbpVnextPro.Notice.Notifications;
using King.AbpVnextPro.Notice.Notifications.EventBus;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using Microsoft.Extensions.Logging;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job
{
    [DisallowConcurrentExecution]
    public class HttpJob : IJob
    {
        private IHttpClientFactory _httpClientFactory { get; set; }
        private IScheduleEntityRepository _scheduleEntityRepository { get; set; }
        private IScheduleLogEntityRepository _scheduleLogEntityRepository { get; set; }
        private IQuartzManager _quartzManager { get; set; }
        private ISettingProvider _settingProvider { get; set; }
        private INotificationAppService _notificationAppService { get; set; }
        private ILogger<HttpJob> _logger { get; set; }
        public HttpJob(IHttpClientFactory httpClientFactory, IScheduleEntityRepository scheduleEntityRepository, IQuartzManager quartzManager, IScheduleLogEntityRepository scheduleLogEntityRepository, ISettingProvider settingProvider, INotificationAppService notificationAppService, ILogger<HttpJob> logger)
        {
            _httpClientFactory = httpClientFactory;
            _scheduleEntityRepository = scheduleEntityRepository;
            _quartzManager = quartzManager;
            _scheduleLogEntityRepository = scheduleLogEntityRepository;
            _settingProvider = settingProvider;
            _notificationAppService = notificationAppService;
            _logger = logger;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Run(context);
        }

        public async Task Run(IJobExecutionContext context)
        {
            Stopwatch stopwatch = new Stopwatch();
            IJobDetail job = context.JobDetail;
            var instance = job.JobDataMap["JobParam"] as ScheduleManagerDto;

            var httpClient = _httpClientFactory.CreateClient();
            //自定头部信息  如果  要token 之类的
            string headers = instance.Headers;
            var obj = JsonConvert.DeserializeObject(headers);
            if (obj != null)
            {
                foreach (var x in obj as JObject)
                {
                    httpClient.DefaultRequestHeaders.Add(x.Key, x.Value.ToString());
                }
            }

            string requestBody = string.Empty;
            string url = instance.RequestUrl;
            if (instance.ContentType == "application/json")
            {
                requestBody = instance.Body?.Replace("\r\n", "");
            }
            else if (instance.ContentType == "application/x-www-form-urlencoded")
            {

                var objbody = JsonConvert.DeserializeObject(instance.Body);
                var jobjobjbody = objbody as JObject;
                if (jobjobjbody != null)
                {
                    foreach (var item in jobjobjbody)
                    {
                        requestBody += string.Format("&{0}", $"{item.Key}={item.Value.ToString()}");
                    }
                    if (instance.Method.ToLower() == "get" && jobjobjbody.Count > 0)
                    {
                        url = $"{instance.RequestUrl}?{requestBody}";
                    }
                }
            }
            //获取设置的http 请求时间
            string settinghttptimeout = await _settingProvider.GetOrNullAsync("Http.SettHttpTimeOut");
            int httptimeout = !string.IsNullOrEmpty(settinghttptimeout) ? Convert.ToInt32(settinghttptimeout) : 300;
            TimeSpan timeSpan = new TimeSpan(0, 0, httptimeout);
            httpClient.Timeout = timeSpan;
            var httpRequest = new HttpRequestMessage
            {
                Content = new StringContent(requestBody ?? string.Empty, System.Text.Encoding.UTF8, instance.ContentType),
                Method = new HttpMethod(instance.Method),
                RequestUri = new Uri(url)
            };
            //写入日志
            WritLog(instance.Id, $"即将请求：{url}", "0", instance.JobGroup, instance.Title, 0);
            try
            {
                var response = await httpClient.SendAsync(httpRequest);
                //获取计划任务信息
                var scheduleentity = await _scheduleEntityRepository.FindAsync(x => x.Id == instance.Id);
                //获取调用http 接口结果
                string content = await response.Content.ReadAsStringAsync();

                MessageModel messageModel = Newtonsoft.Json.JsonConvert.DeserializeObject<MessageModel>(content);
                if (response.IsSuccessStatusCode)
                {
                    if (messageModel.IsSuccesss == true)
                    {
                        //成功了,就把 已经重试的次数归为0
                        if (scheduleentity != null)
                        {
                            scheduleentity.AlreadyRetryCount = 0;
                            await _scheduleEntityRepository.UpdateAsync(scheduleentity);
                        }
                        stopwatch.Stop();
                        //写入日志
                        WritLog(instance.Id, $"请求结束，响应码：{response.StatusCode.GetHashCode().ToString()}，响应内容：{(response.Content.Headers.GetValues("content-type").Any(x => x.Contains("text/html")) ? "html文档" : content)}", "0", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);
                    }
                    else
                    {
                        stopwatch.Stop();
                        //写入日志
                        WritLog(instance.Id, $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常，请您即时处理,异常信息:{messageModel.Message}返回状态码是200但是IsSuccesss=false,调用的接口是{instance.RequestUrl}", "1", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);

                        if (scheduleentity != null)
                        {
                            if (scheduleentity.IsAllowMail)
                            {
                                List<KeyValuePair<string, string>> keepers = new List<KeyValuePair<string, string>>();
                                foreach (var item in instance.KeeperInfo)
                                {
                                    keepers.Add(new KeyValuePair<string, string>(item.UserName, item.MailAddress));
                                }
                                //发送邮件
                                 SendMail(keepers, $"任务运行异常 — {instance.Title}", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception(messageModel.Message + $"返回状态码是200但是IsSuccesss=false,调用的接口是：{instance.RequestUrl}")));
                            }
                            if (scheduleentity.IsAllowSms)
                            {

                            }
                            if (scheduleentity.IsAllowSignarl)
                            {
                                //发送站内信
                                 SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常，请您即时处理,异常信息:{messageModel.Message}返回状态码是200但是IsSuccesss=false,调用的接口是{instance.RequestUrl}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                            }

                            //如果有重试功能  根据任务定时时间重试
                            if (scheduleentity.IsHaveRetry)
                            {
                                //如果已经重试次数没有大于 最大的重试次数
                                if (scheduleentity.AlreadyRetryCount < scheduleentity.MaxRetryCount)
                                {
                                    await _quartzManager.RetryJob(scheduleentity.Id, scheduleentity.JobGroup, scheduleentity.RetryInterval.Value);
                                    if (scheduleentity.IsAllowMail)
                                    {
                                        //发送邮件
                                        List<KeyValuePair<string, string>> keepers = new List<KeyValuePair<string, string>>();
                                        foreach (var item in instance.KeeperInfo)
                                        {
                                            keepers.Add(new KeyValuePair<string, string>(item.UserName, item.MailAddress));
                                        }
                                        //发送邮件
                                         SendMail(keepers, $"任务运行异常 — {instance.Title}", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception($"返回码是200，但是IsSuccess是false的第{scheduleentity.AlreadyRetryCount + 1}重试,调用接口url:{instance.RequestUrl}")));
                                    }
                                    if (scheduleentity.IsAllowSms)
                                    {

                                    }
                                    if (scheduleentity.IsAllowSignarl)
                                    {
                                        //发送站内信
                                         SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss")}发生异常,返回码是200，但是IsSuccess是false的第{scheduleentity.AlreadyRetryCount + 1}重试,调用接口url:{instance.RequestUrl}，请您即时处理", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                //写入日志
                WritLog(instance.Id, $"调用接口try-catch 失败 失败原因{ex.Message},StackTrace:{ex.StackTrace}", "1", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);

                //根据任务id 获取邮箱
                //获取计划任务信息
                var scheduleentity = await _scheduleEntityRepository.FindAsync(x => x.Id == instance.Id);


                if (scheduleentity.IsAllowMail)
                {
                    List<KeyValuePair<string, string>> keepers = new List<KeyValuePair<string, string>>();
                    foreach (var item in instance.KeeperInfo)
                    {
                        keepers.Add(new KeyValuePair<string, string>(item.UserName, item.MailAddress));
                    }
                    SendMail(keepers, $"{instance.Title}调用接口报错", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception(ex.Message + $"调用接口报错,调用的接口是：{instance.RequestUrl}")));
                }
                if (scheduleentity.IsAllowSms)
                {

                }
                if (scheduleentity.IsAllowSignarl)
                {
                    //发送站内信
                    SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常,调用的接口是{instance.RequestUrl}，请您即时处理,异常信息：{ex.Message}程序堆栈: {ex.StackTrace}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                }
                //如果有重试功能  根据任务定时时间重试
                if (scheduleentity.IsHaveRetry)
                {
                    //如果已经重试次数没有大于 最大的重试次数
                    if (scheduleentity.AlreadyRetryCount < scheduleentity.MaxRetryCount)
                    {
                        await _quartzManager.RetryJob(instance.Id, instance.JobGroup, scheduleentity.RetryInterval.Value);

                        //写日志
                        stopwatch.Stop();
                        //写入日志
                        WritLog(instance.Id, $"调用接口try-catch 失败 的情况下的第{scheduleentity.AlreadyRetryCount + 1}重试", "1", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);

                        //邮件，短信，站内信
                        if (scheduleentity.IsAllowMail)
                        {
                            List<KeyValuePair<string, string>> keepers = new List<KeyValuePair<string, string>>();
                            foreach (var item in instance.KeeperInfo)
                            {
                                keepers.Add(new KeyValuePair<string, string>(item.UserName, item.MailAddress));
                            }
                            //发送邮件
                            SendMail(keepers, $"{instance.Title}调用接口报错", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception($"调用接口try-catch 失败 的情况下的第{scheduleentity.AlreadyRetryCount + 1}重试,调用接口url:{instance.RequestUrl}")));
                        }
                        if (scheduleentity.IsAllowSms)
                        {

                        }
                        if (scheduleentity.IsAllowSignarl)
                        {
                            //发送站内信
                            SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常,调用接口try-catch 失败 的情况下的第{scheduleentity.AlreadyRetryCount + 1}重试,调用接口url:{instance.RequestUrl}，请您即时处理,异常信息：{ex.Message}程序堆栈: {ex.StackTrace}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                        }
                    }
                    else  //重置已经重试的次数 如果本次的重试的次数已经大于最大重试次数的话
                    {
                        scheduleentity.AlreadyRetryCount = 0;
                        await _scheduleEntityRepository.UpdateAsync(scheduleentity);
                    }
                }
            }

        }

        private async void WritLog(Guid id, string jobmessage, string status, string jobgroup, string jobName, double elapsed)
        {
            try
            {
                ScheduleLogEntity scheduleLogEntity = new ScheduleLogEntity()
                {
                    ScheduleId = id,
                    JobMessage = jobmessage,
                    Status = status,
                    JobGroup = jobgroup,
                    JobName = jobName,
                    Elapsed = elapsed
                };

                await _scheduleLogEntityRepository.InsertAsync(scheduleLogEntity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"写计划任务日志出错，错误原因{ex.Message},StackTrace:{ex.StackTrace}");
            }

        }

        private async void SendMail(List<KeyValuePair<string, string>> toaddresslist, string title, string content)
        {
            //发送邮件
            string host = await _settingProvider.GetOrNullAsync("Abp.Mailing.Smtp.Host");
            string port = await _settingProvider.GetOrNullAsync("Abp.Mailing.Smtp.Port");
            string username = await _settingProvider.GetOrNullAsync("Abp.Mailing.DefaultFromAddress");
            string password = await _settingProvider.GetOrNullAsync("Abp.Mailing.Smtp.Password");
            string fromaccountname = await _settingProvider.GetOrNullAsync("Abp.Mailing.DefaultFromDisplayName");
            try
            {
                MailKitHelper.SendMail(
                   host, Convert.ToInt32(port), username, password, fromaccountname,
                   toaddresslist,
                  title,
                  content);
            }
            catch (Exception ex)
            {
                _logger.LogError($"发送邮件出错，错误原因{ex.Message},StackTrace:{ex.StackTrace}");
               
            }
        }

        private async void SendNoticeMsg(string title, string content, Guid? from, List<Guid> userid)
        {
            try
            {
                //发送站内信
                SendCommonMessageInput msg = new SendCommonMessageInput()
                {
                    Title = title,
                    Content = content,
                    From = from,
                    ReceiveIds = userid
                };
                await _notificationAppService.SendCommonErrorMessageAsync(msg);
            }
            catch (Exception ex)
            {
                _logger.LogError($"发送站内信出错，错误原因{ex.Message},StackTrace:{ex.StackTrace}");
            }
        }
    }
}
