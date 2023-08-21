using King.AbpVnextPro.Openiddict.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Openiddict;

public abstract class OpeniddictAppService : ApplicationService
{
    protected OpeniddictAppService()
    {
        LocalizationResource = typeof(OpeniddictResource);
        ObjectMapperContext = typeof(OpeniddictApplicationModule);
    }
}
