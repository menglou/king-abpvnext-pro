using Localization.Resources.AbpUi;
using King.AbpVnextPro.ScheduleTask.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(ScheduleTaskApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ScheduleTaskHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ScheduleTaskHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ScheduleTaskResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
