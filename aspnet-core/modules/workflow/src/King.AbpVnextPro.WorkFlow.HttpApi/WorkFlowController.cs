using King.AbpVnextPro.WorkFlow.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.WorkFlow;

public abstract class WorkFlowController : AbpControllerBase
{
    protected WorkFlowController()
    {
        LocalizationResource = typeof(WorkFlowResource);
    }
}
