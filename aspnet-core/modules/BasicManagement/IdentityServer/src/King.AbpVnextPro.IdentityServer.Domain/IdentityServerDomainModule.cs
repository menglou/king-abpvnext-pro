using Volo.Abp.AuditLogging;
using Volo.Abp.AutoMapper;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Domain;
using Volo.Abp.Emailing;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;

using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;

using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace King.AbpVnextPro.IdentityServer;

[DependsOn(
        typeof(AbpDddDomainModule),
        typeof(IdentityServerDomainSharedModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpBackgroundJobsDomainModule),
        typeof(AbpFeatureManagementDomainModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpSettingManagementDomainModule),
        typeof(AbpTenantManagementDomainModule),
        typeof(AbpEmailingModule)
)]
public class IdentityServerDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<IdentityServerDomainModule>();
        });
    }
}
