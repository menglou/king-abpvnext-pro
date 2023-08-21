using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.IdentityServer;

public abstract class IdentityServerController : AbpControllerBase
{
    protected IdentityServerController()
    {
        LocalizationResource = typeof(IdentityServerResource);
    }
}
