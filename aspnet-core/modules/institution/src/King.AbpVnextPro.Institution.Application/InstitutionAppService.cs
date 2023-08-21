using King.AbpVnextPro.Institution.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Institution;

public abstract class InstitutionAppService : ApplicationService
{
    protected InstitutionAppService()
    {
        LocalizationResource = typeof(InstitutionResource);
        ObjectMapperContext = typeof(InstitutionApplicationModule);
    }
}
