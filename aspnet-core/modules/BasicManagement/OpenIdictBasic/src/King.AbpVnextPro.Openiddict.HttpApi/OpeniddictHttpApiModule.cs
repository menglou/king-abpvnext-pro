using Localization.Resources.AbpUi;
using King.AbpVnextPro.Openiddict.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;

namespace King.AbpVnextPro.Openiddict;

[DependsOn(
typeof(OpeniddictApplicationContractsModule),
typeof(AbpAspNetCoreMvcModule),
typeof(AbpAccountHttpApiModule),
typeof(AbpIdentityHttpApiModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule)

    )]
public class OpeniddictHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(OpeniddictHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<OpeniddictResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
