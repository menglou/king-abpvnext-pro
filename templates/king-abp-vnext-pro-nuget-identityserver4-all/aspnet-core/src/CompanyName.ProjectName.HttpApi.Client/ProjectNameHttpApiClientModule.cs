using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using King.AbpVnextPro.IdentityServer;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.ScheduleTask;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.Institution;

namespace CompanyName.ProjectName;
[DependsOn(
    typeof(ProjectNameApplicationContractsModule),
    typeof(IdentityServerHttpApiClientModule),
    typeof(NoticeHttpApiClientModule),
    typeof(DictionaryHttpApiClientModule),
    typeof(FileHttpApiClientModule),
    typeof(ScheduleTaskHttpApiClientModule),
    typeof(PayCenterHttpApiClientModule),
    typeof(InstitutionHttpApiClientModule)
)]
public class ProjectNameHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ProjectNameApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProjectNameHttpApiClientModule>();
        });
    }
}
