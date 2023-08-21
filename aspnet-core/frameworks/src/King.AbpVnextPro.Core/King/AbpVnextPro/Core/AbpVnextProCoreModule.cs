using King.AbpVnextPro.Core.Extensions;
using King.AbpVnextPro.Core.King.AbpVnextPro.Core;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.Core;

[DependsOn(typeof(AbpVnextProLocalizationModule))]
public class AbpVnextProCoreModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClient();
        context.Services.AddSingleton<WeChatHelper>();
    }
}