using EasyAbp.Abp.SettingUi;
using EasyAbp.Abp.SettingUi.Localization;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.File.Localization;
using King.AbpVnextPro.Institution;
using King.AbpVnextPro.Localization;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.Openiddict.Localization;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.PayCenter.Localization;
using King.AbpVnextPro.ScheduleTask;
using King.AbpVnextPro.ScheduleTask.Localization;
using OpenIddict.Abstractions;
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

namespace King.AbpVnextPro;

[DependsOn(
    typeof(AbpOpenIddictDomainSharedModule),
    typeof(AbpSettingUiDomainSharedModule),
    typeof(OpeniddictDomainSharedModule),
    typeof(NoticeDomainSharedModule),
    typeof(DictionaryDomainSharedModule),
    typeof(FileDomainSharedModule),
    typeof(ScheduleTaskDomainSharedModule),
    typeof(PayCenterDomainSharedModule),
    typeof(InstitutionDomainSharedModule)
    )]
public class AbpVnextProDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AbpVnextProGlobalFeatureConfigurator.Configure();
        AbpVnextProModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpVnextProDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpVnextProResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/AbpVnextPro");

            options.Resources
                   .Get<SettingUiResource>()
                   .AddVirtualJson("/Localization/AbpVnextPro")
                   .AddBaseTypes(typeof(FileResource));


            options.Resources
                .Get<SettingUiResource>()
                .AddVirtualJson("/Localization/AbpVnextPro")
                .AddBaseTypes(typeof(OpeniddictResource));

            options.Resources
                .Get<SettingUiResource>()
                .AddVirtualJson("/Localization/AbpVnextPro")
                .AddBaseTypes(typeof(PayCenterResource));

            options.DefaultResourceType = typeof(AbpVnextProResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("AbpVnextPro", typeof(AbpVnextProResource));
        });
    }
}
