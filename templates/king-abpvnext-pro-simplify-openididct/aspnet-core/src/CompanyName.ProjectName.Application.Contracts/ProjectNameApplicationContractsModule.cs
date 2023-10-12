using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Openiddict;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CompanyName.ProjectName;

[DependsOn(
    typeof(ProjectNameDomainSharedModule),
    typeof(OpeniddictApplicationContractsModule),
    typeof(NoticeApplicationContractsModule),
    typeof(AbpSettingUiApplicationContractsModule)
)]
public class ProjectNameApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        ProjectNameDtoExtensions.Configure();
    }
}
