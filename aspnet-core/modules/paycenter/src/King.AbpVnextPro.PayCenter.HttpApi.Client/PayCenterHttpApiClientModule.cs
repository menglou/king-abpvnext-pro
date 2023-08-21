using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.PayCenter;

[DependsOn(
    typeof(PayCenterApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class PayCenterHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(PayCenterApplicationContractsModule).Assembly,
            PayCenterRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PayCenterHttpApiClientModule>();
        });

    }
}
