using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

using Volo.Abp.ObjectExtending;
using Volo.Abp.ObjectExtending.Modularity;
using King.AbpVnextPro.Openiddict.Volo.Identity;
using EasyAbp.Abp.SettingUi;

namespace King.AbpVnextPro.Openiddict;

[DependsOn(
typeof(OpeniddictDomainSharedModule),
typeof(AbpDddApplicationContractsModule),
typeof(AbpAuthorizationModule),
typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule),
     typeof(AbpSettingUiApplicationContractsModule)
    )]
public class OpeniddictApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        BasicManagementDtoExtensions.Configure();

        ModuleExtensionConfigurationHelper
              .ApplyEntityConfigurationToApi(
                  IdentityModuleExtensionConsts.ModuleName,
                  IdentityModuleExtensionConsts.EntityNames.OrganizationUnit,
                  getApiTypes: new[] { typeof(OrganizationUnitDto) },
                  createApiTypes: new[] { typeof(OrganizationUnitCreateDto) },
                  updateApiTypes: new[] { typeof(OrganizationUnitUpdateDto) }
              );
    }
}
