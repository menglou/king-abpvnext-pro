using Localization.Resources.AbpUi;
using King.AbpVnextPro.Institution.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.Institution;

[DependsOn(
    typeof(InstitutionApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class InstitutionHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(InstitutionHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<InstitutionResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
