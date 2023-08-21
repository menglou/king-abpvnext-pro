using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace King.AbpVnextPro.Openiddict;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class OpeniddictInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OpeniddictInstallerModule>();
        });
    }
}
