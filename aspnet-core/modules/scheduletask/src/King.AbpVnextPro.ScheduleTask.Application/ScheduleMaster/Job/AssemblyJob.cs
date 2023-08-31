
using ICSharpCode.SharpZipLib.Zip;
using JetBrains.Annotations;
using King.AbpVnextPro.Core.King.AbpVnextPro.Core;
using King.AbpVnextPro.File;
using King.AbpVnextPro.File.Filess;
using King.AbpVnextPro.Notice.Notifications;
using King.AbpVnextPro.Notice.Notifications.EventBus;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager;
using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job
{
    public class AssemblyJob : IJob
    {
        private ScheduleTaskAssemblyContext loadContext;
        public TaskInstance RunnableInstance;
        private ILogger<HttpJob> _logger { get; set; }
        private IFilesAppService _filesAppService;
        private ISettingProvider _settingProvider { get; set; }
        private INotificationAppService _notificationAppService { get; set; }
        private IScheduleEntityRepository _scheduleEntityRepository { get; set; }
        private IScheduleLogEntityRepository _scheduleLogEntityRepository { get; set; }
        private IQuartzManager _quartzManager { get; set; }
        public AssemblyJob(ILogger<HttpJob> logger, IFilesAppService filesAppService,ISettingProvider settingProvider, INotificationAppService notificationAppService, IScheduleEntityRepository scheduleEntityRepository, IScheduleLogEntityRepository scheduleLogEntityRepository, IQuartzManager quartzManager)
        {
            _logger = logger;
            _filesAppService = filesAppService;
            _settingProvider = settingProvider;
            _notificationAppService = notificationAppService;
            _scheduleEntityRepository = scheduleEntityRepository;
            _scheduleLogEntityRepository= scheduleLogEntityRepository;
            _quartzManager = quartzManager;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Run(context);
        }

        private async Task Run(IJobExecutionContext context)
        {
            IJobDetail job = context.JobDetail;
            var jobparam = job.JobDataMap["JobParam"] as ScheduleManagerDto;
            _logger.LogInformation("---------创建程序集实例实例-----------");
           
            CreateRunnableInstance(jobparam,jobparam.Id, jobparam.FileName, jobparam.AssemblyName, jobparam.ClassName, jobparam.MethodName);
        }

        //创建程序集实例 并执行方法
        private async void CreateRunnableInstance(ScheduleManagerDto instance, Guid sid, string filename, string assemblyName, string className, string methodName)
        {
            string dllpath = string.Empty;
            string basepath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\plugins";
            //程序集的路径
            string assemblyPath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\plugins\\{sid}\\{filename}";
            //判断文件夹存不存在,不存在就创建
            if (!Directory.Exists(assemblyPath))
            {
                //根据id 获取存在在blob 中文件
                var fileDto = await _filesAppService.FindByBlobNameAsync(filename);
                //根据上传到blob 的文件解压zip 文件
                string didcpath = ExtractProjectZip(fileDto.Bytes, basepath, sid, filename, assemblyName);

                dllpath = $"{didcpath}\\{assemblyName}.dll";
            }
            else
            {
                dllpath = $"{assemblyPath}\\{filename}\\{assemblyName}.dll";
            }

            //加载程序集的文件地址
            string contextpath = dllpath.Replace('\\', Path.DirectorySeparatorChar);
            Stopwatch stopwatch = new Stopwatch();
            try
            {
                //获取计划任务信息
                var scheduleentity = await _scheduleEntityRepository.FindAsync(x => x.Id == instance.Id);
                WeakReference weakReference;
                loadContext = AssemblyHelper.LoadAssemblyContext(contextpath);
                RunnableInstance = AssemblyHelper.CreateTaskInstance(
                    loadContext,
                    contextpath,
                    className,
                    out weakReference
                );
                if (RunnableInstance == null)
                {
                    //写入日志
                    WritLog(instance.Id, $"任务实例创建失败。程序集：{assemblyName}，类型：{className},方法名{methodName}", "1", instance.JobGroup, instance.Title, 0);

                    stopwatch.Stop();
                    //写入日志
                    WritLog(instance.Id, $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常，请您即时处理,异常信息:任务实例创建失败。程序集：{assemblyName}，类型：{className},方法名{methodName}", "1", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);

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
                            SendMail(keepers, $"任务运行异常 — {instance.Title}", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception( $"任务实例创建失败。程序集：{assemblyName}，类型：{className},方法名{methodName}")));
                        }
                        if (scheduleentity.IsAllowSms)
                        {

                        }
                        if (scheduleentity.IsAllowSignarl)
                        {
                            //发送站内信
                            SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常，请您即时处理,异常信息:任务实例创建失败。程序集：{assemblyName}，类型：{className},方法名{methodName}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
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
                                    SendMail(keepers, $"任务运行异常 — {instance.Title}", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception($"程序集：{assemblyName}，类型：{className},方法名{methodName}")));
                                }
                                if (scheduleentity.IsAllowSms)
                                {

                                }
                                if (scheduleentity.IsAllowSignarl)
                                {
                                    //发送站内信
                                    SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss")}发生异常,程序集：{assemblyName}，类型：{className},方法名{methodName}，请您即时处理", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
                                }
                            }
                        }
                    }
                    return;
                }
                //写入日志
                WritLog(instance.Id, $"开始调用程序集方法。程序集：{assemblyName}，类型：{className},方法名{methodName}", "0", instance.JobGroup, instance.Title, 0);

                _logger.LogInformation("-----------开始调用程序集方法------------");
               
                //开启一个计时

                //调用方法
                RunnableInstance.Type.GetMethod(methodName).Invoke(RunnableInstance.Instance, new object[] { });

                //成功了,就把 已经重试的次数归为0
                if (scheduleentity != null)
                {
                    scheduleentity.AlreadyRetryCount = 0;
                    await _scheduleEntityRepository.UpdateAsync(scheduleentity);
                }
                stopwatch.Stop();
                //写入日志
                WritLog(instance.Id, $"调用程序集方法结束：程序集：{assemblyName}，类型：{className},方法名{methodName}", "0", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);

                _logger.LogInformation($"-----------调用程序集方法结束,用时{stopwatch.ElapsedMilliseconds}------------");

                _logger.LogInformation("-----------开始卸载程序集------------");
                //写入日志
                WritLog(instance.Id, $"开始卸载程序集：程序集：{assemblyName}，类型：{className},方法名{methodName}", "0", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);
                //卸载实例
                AssemblyHelper.UnLoadAssemblyLoadContext(loadContext, weakReference);
                //写入日志
                WritLog(instance.Id, $"卸载程序集结束：程序集：{assemblyName}，类型：{className},方法名{methodName}", "0", instance.JobGroup, instance.Title, stopwatch.Elapsed.TotalMilliseconds);
                _logger.LogInformation("-----------卸载程序集结束------------");
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
                    SendMail(keepers, $"{instance.Title}调用程序集报错", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception(ex.Message )));
                }
                if (scheduleentity.IsAllowSms)
                {

                }
                if (scheduleentity.IsAllowSignarl)
                {
                    //发送站内信
                    SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常,调用的程序集是{instance.AssemblyName},类的名称空间{instance.ClassName},方法名{instance.Method}，请您即时处理,异常信息：{ex.Message}程序堆栈: {ex.StackTrace}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
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
                            SendMail(keepers, $"{instance.Title}调用程序集报错", MailTemplateHelper.GetErrorEmailContent(instance.Title, new Exception($"调用接口try-catch 失败 的情况下的第{scheduleentity.AlreadyRetryCount + 1}重试,调用程序集:{instance.AssemblyName},类的名称空间{instance.ClassName},方法名{instance.Method}")));
                        }
                        if (scheduleentity.IsAllowSms)
                        {

                        }
                        if (scheduleentity.IsAllowSignarl)
                        {
                            //发送站内信
                            SendNoticeMsg($"任务运行异常 — {instance.Title}", $"感谢你使用澄水计划任务调度平台,你参与的任务{instance.Title}在{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}发生异常,调用接口try-catch 失败 的情况下的第{scheduleentity.AlreadyRetryCount + 1}重试,调用程序集:{instance.AssemblyName},类的名称空间{{instance.ClassName}},方法名{{instance.Method}}\"，请您即时处理,异常信息：{ex.Message}程序堆栈: {ex.StackTrace}", instance.Id, instance.KeeperInfo.Select(x => x.UserId).ToList());
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

        /// <summary>
        /// byte[转成zip 并解压
        /// </summary>
        /// <param name="filebytes"></param>
        /// <param name="assemblyPath"></param>
        /// <param name="sid"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string ExtractProjectZip(byte[] filebytes, string assemblyPath, Guid sid, string filename, string assemblayname)
        {
            //文件加路径
            string basepath = Path.Combine(assemblyPath, sid.ToString(), filename);
            //zip 路径
            string savepath = Path.Combine(basepath, filename + ".zip");

            string extractpath = Path.Combine(basepath, filename);

            //判断文件夹路径在不在，不在创建
            if (!Directory.Exists(basepath))
            {
                Directory.CreateDirectory(basepath);
            }

            //判断文件路径在不在，在就删除
            if (System.IO.File.Exists(savepath))
            {
                System.IO.File.Delete(savepath);
            }

            //判断解压后的文件路径在不在，在就删除
            if (Directory.Exists(extractpath))
            {
                Directory.Delete(extractpath);
            }

            using (FileStream fs = new FileStream(savepath, FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(filebytes, 0, filebytes.Length);
                fs.Close();
            }
            //解压 到某个目录
            UnZip(savepath, extractpath);

            //返回解压后的路径
            return extractpath;
        }


        /// <summary>  
        /// 功能：解压zip格式的文件。  
        /// </summary>  
        /// <param name="zipFilePath">压缩文件路径</param>  
        /// <param name="unZipDir">解压文件存放路径,为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹</param>  
        /// <returns>解压是否成功</returns>  
        public void UnZip(string zipFilePath, string unZipDir)
        {
            //判断压缩文件路径是否为空
            if (zipFilePath == string.Empty)
            {
                //如果为空，则抛出异常
                throw new Exception("压缩文件不能为空！");
            }

            //判断压缩文件是否存在
            if (!System.IO.File.Exists(zipFilePath))
            {
                throw new FileNotFoundException("压缩文件不存在！");
            }
            //解压文件夹为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹  
            if (unZipDir == string.Empty) unZipDir = zipFilePath.Replace(Path.GetFileName(zipFilePath), Path.GetFileNameWithoutExtension(zipFilePath));

            //如果解压文件夹路径不以“/”结尾，则添加“/”
            if (!unZipDir.EndsWith("/")) unZipDir += "/";

            //如果解压文件夹不存在，则创建该文件夹
            if (!Directory.Exists(unZipDir)) Directory.CreateDirectory(unZipDir);

            //用于读取zip文件中的数据
            using (var s = new ZipInputStream(System.IO.File.OpenRead(zipFilePath)))
            {
                ZipEntry theEntry;
                //循环读取zip文件中的每一个文件
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    //获取文件所在的文件夹路径
                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    //获取文件名
                    string fileName = Path.GetFileName(theEntry.Name);

                    //获取文件名
                    if (!string.IsNullOrEmpty(directoryName))
                    {
                        //创建该文件夹
                        Directory.CreateDirectory(unZipDir + directoryName);
                    }

                    //如果文件所在的文件夹路径不为空且不以“/”结尾
                    if (directoryName != null && !directoryName.EndsWith("/"))
                    { }

                    //如果文件名不为空
                    if (fileName != String.Empty)
                    {
                        //创建文件流
                        using (FileStream streamWriter = System.IO.File.Create(unZipDir + theEntry.Name))
                        {
                            int size;
                            byte[] data = new byte[2048];
                            //循环读取文件流中的数据
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    //将数据写入文件流
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }


        //写日志
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
        //发邮件
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
        //站内信
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
