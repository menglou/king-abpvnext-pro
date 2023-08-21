using Localization.Resources.AbpUi;
using King.AbpVnextPro.PayCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.PayCenter;

[DependsOn(
    typeof(PayCenterApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PayCenterHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PayCenterHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PayCenterResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
