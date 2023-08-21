using King.AbpVnextPro.Openiddict.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.Openiddict;

public abstract class OpeniddictController : AbpControllerBase
{
    protected OpeniddictController()
    {
        LocalizationResource = typeof(OpeniddictResource);
    }
}
