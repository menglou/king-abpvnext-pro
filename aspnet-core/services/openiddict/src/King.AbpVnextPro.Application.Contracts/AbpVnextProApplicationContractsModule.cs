using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.Institution;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.ScheduleTask;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace King.AbpVnextPro;

[DependsOn(
    typeof(AbpVnextProDomainSharedModule),
    typeof(AbpSettingUiApplicationContractsModule),
    typeof(OpeniddictApplicationContractsModule),
    typeof(NoticeApplicationContractsModule),
    typeof(DictionaryApplicationContractsModule),
    typeof(FileApplicationContractsModule),
    typeof(ScheduleTaskApplicationContractsModule),
    typeof(InstitutionApplicationContractsModule),
    typeof(PayCenterApplicationContractsModule)
)]
public class AbpVnextProApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AbpVnextProDtoExtensions.Configure();
    }
}
