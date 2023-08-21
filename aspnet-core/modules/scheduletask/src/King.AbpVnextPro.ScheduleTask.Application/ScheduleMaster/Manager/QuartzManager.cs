using Castle.Core.Configuration;
using King.AbpVnextPro.Core.King.AbpVnextPro.Core;
using King.AbpVnextPro.Notice.Notifications;
using King.AbpVnextPro.Notice.Notifications.EventBus;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job;
using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.Logging;
using MimeKit;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using Quartz.Impl.Triggers;
using Quartz.Logging;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager
{
    public class QuartzManager : IQuartzManager
    {
        private IJobFactory _jobFactory;
        private ILogger<QuartzManager> _logger { get; set; }
        private Task<IScheduler> _scheduler;
        private IScheduleEntityRepository _scheduleEntityRepository;
        private INotificationAppService _notificationAppService;
        private ISettingProvider _settingProvider;
        public QuartzManager(IJobFactory jobFactory, ILogger<QuartzManager> logger, IScheduleEntityRepository scheduleEntityRepository, INotificationAppService notificationAppService, ISettingProvider settingProvider)
        {
            _jobFactory = jobFactory;
            _scheduler = GetTaskSchedulerAsync();
            _logger = logger;
            _scheduleEntityRepository = scheduleEntityRepository;
            _notificationAppService = notificationAppService;
            _settingProvider = settingProvider;
        }

        /// <summary>
        /// 开启计划任务
        /// 参考文章：https://www.quartz-scheduler.net/documentation/quartz-3.x/configuration/reference.html#datasources-ado-net-jobstores
        /// </summary>
        /// <returns></returns>
        public Task<IScheduler> GetTaskSchedulerAsync()
        {
            if (_scheduler != null)
            {
                return _scheduler;
            }

            NameValueCollection collection = new NameValueCollection
            {
                { "quartz.serializer.type","binary" },
                //quartz参数
                //{ "quartz.scheduler.instanceId", "AUTO" },
                //{ "quartz.serializer.type","json" },
                ////下面为指定quartz持久化数据库的配置
                //{ "quartz.jobStore.type","Quartz.Impl.AdoJobStore.JobStoreTX, Quartz" },
                //{ "quartz.jobStore.tablePrefix","QRTZ_"},
                //{ "quartz.jobStore.driverDelegateType", "Quartz.Impl.AdoJobStore.MySQLDelegate, Quartz"},
                //{ "quartz.jobStore.useProperties", "true"},
                //{ "quartz.jobStore.dataSource", "myDS" },
                //{ "quartz.dataSource.myDS.connectionString", @"server=xxx.xxx.xxx.xxx;port=3306;database=Admin;uid=zrry;pwd=********;Charset=utf8;"},
                //{ "quartz.dataSource.myDS.provider", "MySql" },
            };

            StdSchedulerFactory factory = new StdSchedulerFactory(collection);

            return _scheduler = factory.GetScheduler();
        }

        /// <summary>
        /// 关闭调度系统
        /// </summary>
        public async Task Shutdown(bool isOnStop = false)
        {
            try
            {
                //判断调度是否已经关闭
                if (_scheduler != null && _scheduler.Result.IsShutdown)
                {
                    //等待任务运行完成再关闭调度
                    await _scheduler.Result.Clear();
                    await _scheduler.Result.Shutdown(true);
                    _scheduler = null;
                }

                _logger.LogInformation("任务调度平台已经停止！");
            }
            catch (Exception ex)
            {
                _logger.LogError("任务调度平台停止失败！", ex);
            }
        }

        /// <summary>
        /// 启动调度中心
        /// </summary>
        /// <returns></returns>
        public async Task<bool> StartTaskScheduleAsync()
        {
            try
            {
                _scheduler.Result.JobFactory = _jobFactory;
                if (_scheduler.Result.IsStarted)
                {
                    return false;
                }
                //等待任务运行完成
                await _scheduler.Result.Start();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 添加一个计划全新的任务
        /// </summary>
        /// <param name="tasksQz"></param>
        /// <returns></returns>
        public async Task<ITrigger> AddTaskScheduleAsync(ScheduleManagerDto tasksQz)
        {
            try
            {
                JobKey jobKey = new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                if (await _scheduler.Result.CheckExists(jobKey))
                {
                    _logger.LogError($"该计划任务已经在执行:【{tasksQz.Title}】,请勿重复添加！");
                    return null;
                }
                if (tasksQz?.EndDate <= DateTime.Now)
                {
                    _logger.LogError($"结束时间小于当前时间计划将不会被执行");
                    return null;
                }
                #region 设置开始时间和结束时间

                tasksQz.StartDate = tasksQz.StartDate == null ? DateTime.Now : tasksQz.StartDate;
                tasksQz.EndDate = tasksQz.EndDate == null ? DateTime.MaxValue.AddDays(-1) : tasksQz.EndDate;

                DateTimeOffset starRunTime = DateBuilder.NextGivenSecondDate(tasksQz.StartDate, 1);//设置开始时间
                DateTimeOffset endRunTime = DateBuilder.NextGivenSecondDate(tasksQz.EndDate, 1);//设置暂停时间

                #endregion

                //2、开启调度器。判断任务调度是否开启
                if (!_scheduler.Result.IsStarted)
                {
                    await StartTaskScheduleAsync();
                }

                //3、创建任务。传入反射出来的执行程序集
                //IJobDetail job = new JobDetailImpl(tasksQz.Id.ToString(), tasksQz.JobGroup, jobType);
                //job.JobDataMap.Add("JobParam", tasksQz);

                IJobDetail job;
                JobDataMap map = new JobDataMap
                {
                    new KeyValuePair<string, object> ("JobParam",tasksQz),
                };

                if (tasksQz.JobType == JobTypeEnum.Url)
                {
                    //job = new JobDetailImpl(tasksQz.Id.ToString(), tasksQz.JobGroup, typeof(HttpJob));
                    //job.JobDataMap.Add("JobParam", map);
                    job = JobBuilder.Create(typeof(HttpJob)).WithIdentity(jobKey).UsingJobData(map).Build();
                }
                else
                {
                    job = JobBuilder.Create(typeof(AssemblyJob)).WithIdentity(jobKey).UsingJobData(map).Build();
                }
                //添加监听器
                var listener = new JobRunListener(tasksQz.Id.ToString(), _settingProvider, _notificationAppService, _logger);
                listener.OnSuccess += StartedEvent;
                _scheduler.Result.ListenerManager.AddJobListener(listener, KeyMatcher<JobKey>.KeyEquals(new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup)));
                //_scheduler.Result.ListenerManager.AddJobListener(listener, );

                ITrigger trigger;
                //4、创建一个触发器
                trigger = GetTrigger(tasksQz);
                if (trigger is CronTriggerImpl)
                {
                    //解决Quartz启动后第一次会立即执行问题解决办法
                    ((CronTriggerImpl)trigger).MisfireInstruction = MisfireInstruction.CronTrigger.DoNothing;
                }
                else
                {
                    //解决Quartz启动后第一次会立即执行问题解决办法
                    ((SimpleTriggerImpl)trigger).MisfireInstruction = MisfireInstruction.CronTrigger.DoNothing;
                }
                // 5、将触发器和任务器绑定到调度器中
                await _scheduler.Result.ScheduleJob(job, trigger);

                //任务没有启动、暂停任务
                //if (!tasksQz.IsStart)
                //{
                //    _scheduler.Result.PauseJob(jobKey).Wait();
                //}
                //按新的trigger重新设置job执行
                await _scheduler.Result.ResumeTrigger(trigger.Key);
                _logger.LogInformation($"启动计划任务:【{tasksQz.Title}】成功！");
                return trigger;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"启动计划任务失败，分组：{tasksQz.JobGroup},作业：【{tasksQz.Title}】,error：{ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 停止计划任务
        /// </summary>
        /// <returns></returns>
        public async Task<bool> StopTaskScheduleAsync(ScheduleManagerDto tasksQz)
        {
            try
            {
                JobKey jk = new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                var job = await _scheduler.Result.GetJobDetail(jk);
                if (job != null)
                {
                    //删除quartz有关设置
                    var trigger = new TriggerKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                    await _scheduler.Result.PauseTrigger(trigger);
                    await _scheduler.Result.UnscheduleJob(trigger);
                    await _scheduler.Result.DeleteJob(jk);
                    _scheduler.Result.ListenerManager.RemoveJobListener(tasksQz.Id.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 暂停指定的计划任务
        /// </summary>
        /// <param name="tasksQz"></param>
        /// <returns></returns>
        public async Task<bool> PauseTaskScheduleAsync(ScheduleManagerDto tasksQz)
        {
            try
            {
                JobKey jobKey = new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                if (await _scheduler.Result.CheckExists(jobKey))
                {
                    // 防止创建时存在数据问题 先移除，然后在执行创建操作
                    await _scheduler.Result.PauseJob(jobKey);
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"暂停计划任务:【{tasksQz.Title}】失败，{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 恢复指定计划任务
        /// </summary>
        /// <param name="tasksQz"></param>
        /// <returns></returns>
        public async Task<bool> ResumeTaskScheduleAsync(ScheduleManagerDto tasksQz)
        {
            try
            {
                JobKey jobKey = new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                if (!await _scheduler.Result.CheckExists(jobKey))
                {
                    return false;
                }
                await _scheduler.Result.ResumeJob(jobKey);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 立即运行
        /// </summary>
        /// <param name="tasksQz"></param>
        /// <returns></returns>
        public async Task<bool> RunTaskScheduleAsync(ScheduleManagerDto tasksQz)
        {
            try
            {
                JobKey jobKey = new JobKey(tasksQz.Id.ToString(), tasksQz.JobGroup);
                List<JobKey> jobKeys = _scheduler.Result.GetJobKeys(GroupMatcher<JobKey>.GroupEquals(tasksQz.JobGroup)).Result.ToList();
                if (jobKeys == null || jobKeys.Count == 0)
                {
                    await AddTaskScheduleAsync(tasksQz);
                }

                var triggers = await _scheduler.Result.GetTriggersOfJob(jobKey);
                if (triggers.Count <= 0)
                {
                    _logger.LogError($"未找到触发器[{jobKey.Name}]");
                    return false;
                }
                await _scheduler.Result.TriggerJob(jobKey);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"执行计划任务:【{tasksQz.Title}】失败，{ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// http 接口返回的不是200 的要根据设置进行重试
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="jobGroup"></param>
        /// <param name="retryInterval"></param>
        /// <returns></returns>
        public async Task RetryJob(Guid sid, string jobGroup, int retryInterval)
        {
            SimpleTriggerImpl retryTrigger = new SimpleTriggerImpl(Guid.NewGuid().ToString(), jobGroup);
            retryTrigger.Description = "RetryTrigger";
            retryTrigger.RepeatCount = 0;
            retryTrigger.JobKey = new JobKey(sid.ToString().ToLower(), jobGroup); ;   // connect trigger with current job      
            retryTrigger.StartTimeUtc = DateBuilder.NextGivenMinuteDate(DateTime.Now, retryInterval / 60);  // Execute after 30 seconds from now
            await _scheduler.Result.ScheduleJob(retryTrigger);

            var task = await _scheduleEntityRepository.FindAsync(x => x.Id == sid);
            if (task != null)
            {
                task.AlreadyRetryCount = task.AlreadyRetryCount + 1;
                await _scheduleEntityRepository.UpdateAsync(task);
            }
        }

        #region 创建触发器帮助方法

        /// <summary>
        /// 创建创建trigger
        /// </summary>
        /// <param name="tasksQz"></param>
        /// <returns></returns>
        private ITrigger GetTrigger(ScheduleManagerDto tasksQz)
        {
            if (tasksQz.RunLoop)
            {
                if (!CronExpression.IsValidExpression(tasksQz.CronExpression))
                {
                    throw new Exception("cron表达式验证失败");
                }
                CronTriggerImpl trigger = new CronTriggerImpl
                {
                    CronExpressionString = tasksQz.CronExpression,
                    Name = tasksQz.Title,
                    Key = new TriggerKey(tasksQz.Id.ToString(), tasksQz.JobGroup),
                    Description = tasksQz.Remark,
                    MisfireInstruction = MisfireInstruction.CronTrigger.DoNothing
                };
                if (tasksQz.StartDate.HasValue)
                {
                    if (tasksQz.StartDate.Value < DateTime.Now) tasksQz.StartDate = DateTime.Now;
                    trigger.StartTimeUtc = TimeZoneInfo.ConvertTimeToUtc(tasksQz.StartDate.Value);
                }
                if (tasksQz.EndDate.HasValue)
                {
                    trigger.EndTimeUtc = TimeZoneInfo.ConvertTimeToUtc(tasksQz.EndDate.Value);
                }
                return trigger;
            }
            else
            {
                DateTimeOffset start = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
                if (tasksQz.StartDate.HasValue)
                {
                    start = TimeZoneInfo.ConvertTimeToUtc(tasksQz.StartDate.Value);
                }
                DateTimeOffset end = start.AddMinutes(1);
                if (tasksQz.EndDate.HasValue)
                {
                    end = TimeZoneInfo.ConvertTimeToUtc(tasksQz.EndDate.Value);
                }
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity(tasksQz.Id.ToString(), tasksQz.JobGroup)
                    .StartAt(start)
                    .WithSimpleSchedule(x => x
                    .WithRepeatCount(1).WithIntervalInMinutes(1))
                    .EndAt(end)
                    .Build();
                return trigger;
            }
        }


        //每次运行成功更新 下次运行时间上次运行时间，总的运行次数
        private async void StartedEvent(Guid sid, DateTime? nextRunTime)
        {
            //每次运行成功后更新任务的运行情况
            var task = await _scheduleEntityRepository.FindAsync(x => x.Id == sid);
            if (task == null) return;
            task.LastRunTime = DateTime.Now;
            task.NextRunTime = nextRunTime;
            task.TotalRunCount += 1;
            await _scheduleEntityRepository.UpdateAsync(task);
        }

        #endregion
    }

    /// <summary>
    /// 任务运行状态监听器
    /// </summary>
    internal class JobRunListener : IJobListener
    {
        public delegate void SuccessEventHandler(Guid sid, DateTime? nextTime);
        public string Name { get; set; }
        public event SuccessEventHandler OnSuccess;
        private readonly ISettingProvider _settingProvider;
        private INotificationAppService _notificationAppService;
        private ILogger<QuartzManager> _logger;
        public JobRunListener(string name, ISettingProvider settingProvider, INotificationAppService notificationAppService, ILogger<QuartzManager> logger)
        {
            Name = name;
            _settingProvider = settingProvider;
            _notificationAppService = notificationAppService;
            _logger = logger;
        }

        public Task JobExecutionVetoed(IJobExecutionContext context, CancellationToken cancellationToken)
        {
            return Task.FromResult(0);
        }

        public Task JobToBeExecuted(IJobExecutionContext context, CancellationToken cancellationToken)
        {
            return Task.FromResult(0);
        }

        public Task JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException, CancellationToken cancellationToken)
        {
            IJobDetail job = context.JobDetail;
            var instance = job.JobDataMap["JobParam"] as ScheduleManagerDto;

            if (jobException == null)
            {
                var utcDate = context.Trigger.GetNextFireTimeUtc();
                DateTime? nextTime = utcDate.HasValue ? TimeZoneInfo.ConvertTimeFromUtc(utcDate.Value.DateTime, TimeZoneInfo.Local) : new DateTime?();
                OnSuccess(Guid.Parse(job.Key.Name), nextTime);
            }
            else if (jobException is BusinessRunException)
            {
                Task.Run(() =>
                {
                    if (instance.KeeperInfo.Count > 0)
                    {
                        List<KeyValuePair<string, string>> keepers = new List<KeyValuePair<string, string>>();
                        foreach (var item in instance.KeeperInfo)
                        {
                            keepers.Add(new KeyValuePair<string, string>(item.UserName, item.MailAddress));
                        }
                        SendMail(keepers, $"任务运行异常 — {instance.Title}", MailTemplateHelper.GetErrorEmailContent(instance.Title, (jobException as BusinessRunException).Detail));
                        //发送短信
                        if (instance.IsAllowSms)
                        {

                        }
                        //站内信发送到singr 当中
                        if (instance.IsAllowSignarl)
                        {
                            SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常，请您及时处理,异常信息：{(jobException as BusinessRunException).Detail.Message}程序堆栈: {(jobException as BusinessRunException).Detail.StackTrace}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                        }
                    }
                });
            }
            return Task.FromResult(0);
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

    public class BusinessRunException : JobExecutionException
    {
        public Exception Detail;
        public BusinessRunException(Exception exp)
        {
            Detail = exp;
        }
    }
}
