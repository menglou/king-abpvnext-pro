using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.Notice;

[DependsOn(
    typeof(NoticeApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class NoticeHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(NoticeApplicationContractsModule).Assembly,
            NoticeRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NoticeHttpApiClientModule>();
        });

    }
}
