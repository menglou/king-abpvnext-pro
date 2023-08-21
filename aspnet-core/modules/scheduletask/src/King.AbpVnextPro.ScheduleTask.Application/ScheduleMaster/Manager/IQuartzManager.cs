using King.AbpVnextPro.ScheduleTask.Schedules;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Manager
{
    public interface IQuartzManager
    {
        Task Shutdown(bool isOnStop = false);
        Task<bool> StartTaskScheduleAsync();
        Task<bool> StopTaskScheduleAsync(ScheduleManagerDto tasksQz);
        Task<ITrigger> AddTaskScheduleAsync(ScheduleManagerDto tasksQz);
        Task<bool> PauseTaskScheduleAsync(ScheduleManagerDto tasksQz);
        Task<bool> ResumeTaskScheduleAsync(ScheduleManagerDto tasksQz);
        Task<bool> RunTaskScheduleAsync(ScheduleManagerDto tasksQz);
        Task RetryJob(Guid sid, string jobGroup, int retryInterval);
    }
}
