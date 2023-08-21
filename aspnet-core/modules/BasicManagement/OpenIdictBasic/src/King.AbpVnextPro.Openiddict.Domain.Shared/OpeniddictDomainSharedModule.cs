using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using King.AbpVnextPro.Openiddict.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;

using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.Identity.Localization;
using Volo.Abp.AuditLogging;
using King.AbpVnextPro.Core;

namespace King.AbpVnextPro.Openiddict;
[DependsOn(
typeof(AbpValidationModule),
     typeof(AbpBackgroundJobsDomainSharedModule),
    typeof(AbpFeatureManagementDomainSharedModule),
    typeof(AbpIdentityDomainSharedModule),
    typeof(AbpPermissionManagementDomainSharedModule),
    typeof(AbpSettingManagementDomainSharedModule),
    typeof(AbpTenantManagementDomainSharedModule),
     typeof(AbpAuditLoggingDomainSharedModule),
    typeof(AbpVnextProCoreModule)
)]
public class OpeniddictDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OpeniddictDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<OpeniddictResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/Openiddict");


            options.Resources
            .Get<IdentityResource>()
            .AddVirtualJson("/Localization/Volo/Identity/Localization");

            options.Resources
                .Get<AuditLoggingResource>()
                .AddVirtualJson("/Localization/Volo/AuditLogging/Localization");

            options.DefaultResourceType = typeof(OpeniddictResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("Openiddict", typeof(OpeniddictResource));
        });
    }
}
