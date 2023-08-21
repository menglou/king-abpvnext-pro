using King.AbpVnextPro.ScheduleTask.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.ScheduleTask;

public abstract class ScheduleTaskAppService : ApplicationService
{
    protected ScheduleTaskAppService()
    {
        LocalizationResource = typeof(ScheduleTaskResource);
        ObjectMapperContext = typeof(ScheduleTaskApplicationModule);
    }
}
