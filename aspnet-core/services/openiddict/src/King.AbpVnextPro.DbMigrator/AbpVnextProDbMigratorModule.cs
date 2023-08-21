using King.AbpVnextPro.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpVnextProEntityFrameworkCoreModule),
    typeof(AbpVnextProApplicationContractsModule)
    )]
public class AbpVnextProDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
