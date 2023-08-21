using King.AbpVnextPro.PayCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.PayCenter;

public abstract class PayCenterController : AbpControllerBase
{
    protected PayCenterController()
    {
        LocalizationResource = typeof(PayCenterResource);
    }
}
