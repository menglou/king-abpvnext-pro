using CompanyName.ProjectName.Localization;
using EasyAbp.Abp.SettingUi;
using EasyAbp.Abp.SettingUi.Localization;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.File.Localization;
using King.AbpVnextPro.Institution;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.Openiddict.Localization;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.PayCenter.Localization;
using King.AbpVnextPro.ScheduleTask;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace CompanyName.ProjectName;

[DependsOn(
    typeof(AbpAuditLoggingDomainSharedModule),
    typeof(OpeniddictDomainSharedModule),
    typeof(NoticeDomainSharedModule),
    typeof(AbpFeatureManagementDomainSharedModule),
    typeof(AbpOpenIddictDomainSharedModule),
    typeof(DictionaryDomainSharedModule),
    typeof(FileDomainSharedModule),
    typeof(AbpSettingUiDomainSharedModule),
    typeof(ScheduleTaskDomainSharedModule),
    typeof(PayCenterDomainSharedModule),
    typeof(InstitutionDomainSharedModule)
    )]
public class ProjectNameDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        ProjectNameGlobalFeatureConfigurator.Configure();
        ProjectNameModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProjectNameDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<ProjectNameResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/ProjectName");

            options.Resources
                 .Get<SettingUiResource>()
                 .AddVirtualJson("/Localization/ProjectName")
                 .AddBaseTypes(typeof(FileResource));

            options.Resources
                .Get<SettingUiResource>()
                .AddVirtualJson("/Localization/ProjectName")
                .AddBaseTypes(typeof(OpeniddictResource));

            options.Resources
            .Get<SettingUiResource>()
                .AddVirtualJson("/Localization/ProjectName")
                .AddBaseTypes(typeof(PayCenterResource));

            options.DefaultResourceType = typeof(ProjectNameResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("ProjectName", typeof(ProjectNameResource));
        });
    }
}
