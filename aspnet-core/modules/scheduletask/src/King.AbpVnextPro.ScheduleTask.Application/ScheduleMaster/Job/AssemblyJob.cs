using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base;
using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job
{
    public class AssemblyJob : IJob
    {
        private ScheduleTaskAssemblyContext loadContext;
        public TaskInstance RunnableInstance;
        private ILogger<HttpJob> _logger { get; set; }
        public AssemblyJob(ILogger<HttpJob> logger)
        {
            _logger= logger;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Run(context);
        }

        private async Task Run(IJobExecutionContext context)
        {
            IJobDetail job = context.JobDetail;
            var jobparam = job.JobDataMap["JobParam"] as ScheduleManagerDto;
            _logger.LogInformation("创建程序集实例实例");
            CreateRunnableInstance(jobparam.Id, jobparam.AssemblyName, jobparam.ClassName, jobparam.MethodName);
        }

        private void CreateRunnableInstance(Guid sid, string assemblyName, string className,string methodName)
        {
            WeakReference weakReference; 
            loadContext = AssemblyHelper.LoadAssemblyContext(sid, assemblyName);
            RunnableInstance = AssemblyHelper.CreateTaskInstance(
                loadContext,
                sid,
                assemblyName,
                className,
                out weakReference
            );
            if (RunnableInstance == null)
            {
                throw new InvalidCastException($"任务实例创建失败。程序集：{assemblyName}，类型：{className}");
            }

            _logger.LogInformation("-----------开始调用程序集方法------------");
            Stopwatch stopwatch = new Stopwatch();
            //调用方法
            RunnableInstance.Type.GetMethod(methodName).Invoke(RunnableInstance.Instance, new object[] { });

            stopwatch.Stop();

            _logger.LogInformation($"-----------调用程序集方法结束,用时{stopwatch.ElapsedMilliseconds}------------");

            _logger.LogInformation("-----------开始卸载程序集------------");
            //卸载实例
            AssemblyHelper.UnLoadAssemblyLoadContext(loadContext, weakReference);

            _logger.LogInformation("-----------卸载程序集结束------------");
        }
    }
}
