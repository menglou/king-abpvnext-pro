using Localization.Resources.AbpUi;
using King.AbpVnextPro.WorkFlow.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.WorkFlow;

[DependsOn(
    typeof(WorkFlowApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class WorkFlowHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(WorkFlowHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<WorkFlowResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
