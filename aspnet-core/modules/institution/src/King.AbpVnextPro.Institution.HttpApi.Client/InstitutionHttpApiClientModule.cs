using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.Institution;

[DependsOn(
    typeof(InstitutionApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class InstitutionHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(InstitutionApplicationContractsModule).Assembly,
            InstitutionRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InstitutionHttpApiClientModule>();
        });

    }
}
