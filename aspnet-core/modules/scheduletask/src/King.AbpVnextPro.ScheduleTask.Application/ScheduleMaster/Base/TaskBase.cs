
using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base
{
    /// <summary>
    /// 任务抽象基类，要加入的任务必须继承此类
    /// by hoho
    /// </summary>
    public abstract class TaskBase 
    {
        private readonly IServiceProvider _serviceProvider;
        public TaskBase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
       
        /// <summary>
        /// 执行指定任务
        /// </summary>
        /// <param name="context">作业上下文</param>
        /// <param name="job">业务逻辑方法</param>
        public async Task<ScheduleLogEntity> ExecuteJob(IJobExecutionContext context, Func<Task> job)
        {
            double elapsed = 0;
            int status = 0;
            string logMsg=string.Empty;
            string exception=string.Empty;
            try
            {
                //var s = context.Trigger.Key.Name;
                //记录Job时间
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                //执行任务
                await job();
                stopwatch.Stop();
                elapsed = stopwatch.Elapsed.TotalMilliseconds;
                logMsg = "success";
            }
            catch (Exception ex)
            {
                status = 1;
                logMsg = $"Job Run Fail，Exception：{ex.Message}";
                exception = ex.StackTrace;
                //WxNoticeHelper.SendMsg("任务执行出错", logMsg);
            }

            var logModel = new ScheduleLogEntity()
            {
                Elapsed = elapsed,
                Status = status.ToString(),
                JobMessage = logMsg,
                Exception = exception
            };
            await RecordTaskLog(context, logModel);
            return logModel;
        }

        /// <summary>
        /// 记录到日志
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logModel"></param>
        protected async Task RecordTaskLog(IJobExecutionContext context, ScheduleLogEntity logModel)
        {
            var _scheduleLogEntityRepository = (IScheduleLogEntityRepository)_serviceProvider.GetRequiredService(typeof(IScheduleLogEntityRepository));
            //// 可以直接获取 JobDetail 的值
            IJobDetail job = context.JobDetail  ;
            var instance = job.JobDataMap["JobParam"] as ScheduleManagerDto;

            logModel.InvokeTarget = job.JobType.FullName;
            logModel.ScheduleId = instance.Id;
            logModel.JobGroup = instance.JobGroup;
            logModel.JobName = instance.Title;
            await _scheduleLogEntityRepository.InsertAsync(logModel);
        }
    }
}
