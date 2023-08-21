using Localization.Resources.AbpUi;
using King.AbpVnextPro.Notice.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.Notice;

[DependsOn(
    typeof(NoticeApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class NoticeHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(NoticeHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<NoticeResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
