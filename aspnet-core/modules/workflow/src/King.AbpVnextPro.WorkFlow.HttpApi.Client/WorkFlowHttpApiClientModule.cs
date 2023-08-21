using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.WorkFlow;

[DependsOn(
    typeof(WorkFlowApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class WorkFlowHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(WorkFlowApplicationContractsModule).Assembly,
            WorkFlowRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<WorkFlowHttpApiClientModule>();
        });

    }
}
