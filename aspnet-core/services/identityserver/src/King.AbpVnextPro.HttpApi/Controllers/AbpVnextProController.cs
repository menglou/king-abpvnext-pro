using King.AbpVnextPro.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpVnextProController : AbpControllerBase
{
    protected AbpVnextProController()
    {
        LocalizationResource = typeof(AbpVnextProResource);
    }
}
