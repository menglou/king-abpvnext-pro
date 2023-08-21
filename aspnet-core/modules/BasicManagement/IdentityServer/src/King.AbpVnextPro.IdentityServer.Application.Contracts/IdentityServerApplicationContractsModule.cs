using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using EasyAbp.Abp.SettingUi;
using Volo.Abp.TenantManagement;
using Volo.Abp.ObjectExtending;
using King.AbpVnextPro.IdentityServer.Volo.Identity;
using Volo.Abp.ObjectExtending.Modularity;

namespace King.AbpVnextPro.IdentityServer;

[DependsOn(
    typeof(IdentityServerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
     typeof(AbpSettingUiApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class IdentityServerApplicationContractsModule : AbpModule
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
