using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.IdentityServer;
using King.AbpVnextPro.Notice;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace CompanyName.ProjectName
{
    [DependsOn(
        typeof(ProjectNameDomainModule),
        typeof(ProjectNameApplicationContractsModule),
        typeof(IdentityServerApplicationModule),
        typeof(AbpSettingUiApplicationModule),
        typeof(NoticeApplicationModule)
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
}
