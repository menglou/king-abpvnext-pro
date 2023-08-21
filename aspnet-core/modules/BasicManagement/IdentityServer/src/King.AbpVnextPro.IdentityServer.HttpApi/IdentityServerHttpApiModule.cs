using Localization.Resources.AbpUi;
using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.FeatureManagement;

namespace King.AbpVnextPro.IdentityServer;
[DependsOn(
typeof(IdentityServerApplicationContractsModule),
typeof(AbpAspNetCoreMvcModule),
typeof(AbpAccountHttpApiModule),
typeof(AbpIdentityHttpApiModule),
  typeof(AbpPermissionManagementHttpApiModule),
            typeof(AbpTenantManagementHttpApiModule),
            typeof(AbpFeatureManagementHttpApiModule),
            typeof(AbpSettingManagementHttpApiModule)
)]
public class IdentityServerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(IdentityServerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<IdentityServerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
