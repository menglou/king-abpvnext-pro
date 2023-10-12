using Localization.Resources.AbpUi;
using CompanyName.ProjectName.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using King.AbpVnextPro.IdentityServer;
using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.Notice;

namespace CompanyName.ProjectName
{
    [DependsOn(
        typeof(ProjectNameApplicationContractsModule),
        typeof(IdentityServerHttpApiModule),
        typeof(AbpSettingUiHttpApiModule),
        typeof(NoticeHttpApiModule)
        )]
    public class ProjectNameHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ProjectNameResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}
