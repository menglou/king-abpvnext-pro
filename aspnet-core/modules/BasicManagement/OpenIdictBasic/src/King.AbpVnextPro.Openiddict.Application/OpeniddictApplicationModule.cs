using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.SettingManagement;


namespace King.AbpVnextPro.Openiddict;

[DependsOn(
typeof(OpeniddictDomainModule),
typeof(OpeniddictApplicationContractsModule),
typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class OpeniddictApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<OpeniddictApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>  
        {
            options.AddMaps<OpeniddictApplicationModule>(validate: false);
        });
    }
}
