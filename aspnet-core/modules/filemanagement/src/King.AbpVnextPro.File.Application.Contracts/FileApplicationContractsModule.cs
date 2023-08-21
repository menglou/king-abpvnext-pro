using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using EasyAbp.Abp.SettingUi;

namespace King.AbpVnextPro.File;

[DependsOn(
    typeof(FileDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpSettingUiApplicationContractsModule)
    )]
public class FileApplicationContractsModule : AbpModule
{

}
