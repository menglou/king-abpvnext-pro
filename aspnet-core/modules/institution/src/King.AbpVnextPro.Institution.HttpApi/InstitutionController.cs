using King.AbpVnextPro.Institution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.Institution;

public abstract class InstitutionController : AbpControllerBase
{
    protected InstitutionController()
    {
        LocalizationResource = typeof(InstitutionResource);
    }
}
