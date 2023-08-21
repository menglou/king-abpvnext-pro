using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(ScheduleTaskApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ScheduleTaskHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ScheduleTaskApplicationContractsModule).Assembly,
            ScheduleTaskRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ScheduleTaskHttpApiClientModule>();
        });

    }
}
