using King.AbpVnextPro.WorkFlow.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.WorkFlow;

public abstract class WorkFlowAppService : ApplicationService
{
    protected WorkFlowAppService()
    {
        LocalizationResource = typeof(WorkFlowResource);
        ObjectMapperContext = typeof(WorkFlowApplicationModule);
    }
}
