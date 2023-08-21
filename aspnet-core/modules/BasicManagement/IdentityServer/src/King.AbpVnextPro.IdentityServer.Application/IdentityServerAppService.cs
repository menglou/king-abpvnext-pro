using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.IdentityServer;

public abstract class IdentityServerAppService : ApplicationService
{
    protected IdentityServerAppService()
    {
        LocalizationResource = typeof(IdentityServerResource);
        ObjectMapperContext = typeof(IdentityServerApplicationModule);
    }
}
