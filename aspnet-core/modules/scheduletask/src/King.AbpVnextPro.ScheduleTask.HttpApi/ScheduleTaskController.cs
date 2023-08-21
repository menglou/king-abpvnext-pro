using King.AbpVnextPro.ScheduleTask.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.ScheduleTask;

public abstract class ScheduleTaskController : AbpControllerBase
{
    protected ScheduleTaskController()
    {
        LocalizationResource = typeof(ScheduleTaskResource);
    }
}
