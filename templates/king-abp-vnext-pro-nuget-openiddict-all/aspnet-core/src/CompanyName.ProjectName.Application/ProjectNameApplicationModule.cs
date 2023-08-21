using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.Institution;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.ScheduleTask;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CompanyName.ProjectName;

[DependsOn(
    typeof(ProjectNameDomainModule),
    typeof(ProjectNameApplicationContractsModule),
    typeof(OpeniddictApplicationModule),
    typeof(NoticeApplicationModule),
    typeof(DictionaryApplicationModule),
    typeof(FileApplicationModule),
    typeof(AbpSettingUiApplicationModule),
    typeof(ScheduleTaskApplicationModule),
    typeof(PayCenterApplicationModule),
    typeof(InstitutionApplicationModule),
    typeof(InstitutionApplicationContractsModule),
    typeof(PayCenterApplicationContractsModule)
    )]
public class ProjectNameApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ProjectNameApplicationModule>();
        });
    }
}
