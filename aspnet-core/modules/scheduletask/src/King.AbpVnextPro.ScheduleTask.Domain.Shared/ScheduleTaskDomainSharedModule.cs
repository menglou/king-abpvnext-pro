using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using King.AbpVnextPro.ScheduleTask.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(AbpValidationModule)
)]
public class ScheduleTaskDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ScheduleTaskDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<ScheduleTaskResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/ScheduleTask");

          
            options.DefaultResourceType = typeof(ScheduleTaskResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("ScheduleTask", typeof(ScheduleTaskResource));
        });
    }
}
