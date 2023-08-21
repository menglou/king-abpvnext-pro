using Localization.Resources.AbpUi;
using King.AbpVnextPro.Dictionary.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.Dictionary;

[DependsOn(
    typeof(DictionaryApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class DictionaryHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DictionaryHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DictionaryResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
