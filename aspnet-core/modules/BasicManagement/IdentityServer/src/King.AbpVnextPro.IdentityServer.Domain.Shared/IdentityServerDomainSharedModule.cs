using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Identity.Localization;
using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using King.AbpVnextPro.Core;

namespace King.AbpVnextPro.IdentityServer;
[DependsOn(
    typeof(AbpValidationModule),
    typeof(AbpAuditLoggingDomainSharedModule),
        typeof(AbpBackgroundJobsDomainSharedModule),
        typeof(AbpFeatureManagementDomainSharedModule),
        typeof(AbpIdentityDomainSharedModule),
        typeof(AbpPermissionManagementDomainSharedModule),
        typeof(AbpSettingManagementDomainSharedModule),
        typeof(AbpTenantManagementDomainSharedModule),
        typeof(AbpVnextProCoreModule)
)]
public class IdentityServerDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<IdentityServerDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<IdentityServerResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/IdentityServer");

           
            options.Resources
            .Get<IdentityResource>()
            .AddVirtualJson("/Localization/Volo/Identity/Localization");

            options.Resources
                .Get<AuditLoggingResource>()
                .AddVirtualJson("/Localization/Volo/AuditLogging/Localization");

            options.DefaultResourceType = typeof(IdentityServerResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("IdentityServer", typeof(IdentityServerResource));
        });
    }
}
