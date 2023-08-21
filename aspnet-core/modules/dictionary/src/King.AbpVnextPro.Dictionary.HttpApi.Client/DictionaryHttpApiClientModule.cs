using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.Dictionary;

[DependsOn(
    typeof(DictionaryApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DictionaryHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DictionaryApplicationContractsModule).Assembly,
            DictionaryRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DictionaryHttpApiClientModule>();
        });

    }
}
