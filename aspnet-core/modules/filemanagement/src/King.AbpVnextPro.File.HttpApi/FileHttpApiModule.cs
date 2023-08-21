using Localization.Resources.AbpUi;
using King.AbpVnextPro.File.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.File;

[DependsOn(
    typeof(FileApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class FileHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(FileHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FileResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
