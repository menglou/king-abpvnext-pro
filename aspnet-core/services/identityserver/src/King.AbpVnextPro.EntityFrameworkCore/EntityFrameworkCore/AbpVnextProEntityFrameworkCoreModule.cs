using System;
using King.AbpVnextPro.Dictionary.EntityFrameworkCore;
using King.AbpVnextPro.File.EntityFrameworkCore;
using King.AbpVnextPro.IdentityServer.EntityFrameworkCore;
using King.AbpVnextPro.Institution.EntityFrameworkCore;
using King.AbpVnextPro.Notice.EntityFrameworkCore;
using King.AbpVnextPro.PayCenter.EntityFrameworkCore;
using King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace King.AbpVnextPro.EntityFrameworkCore;

[DependsOn(
    typeof(AbpVnextProDomainModule),
    typeof(IdentityServerEntityFrameworkCoreModule),
    typeof(NoticeEntityFrameworkCoreModule),
    typeof(AbpIdentityServerEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(DictionaryEntityFrameworkCoreModule),
    typeof(FileEntityFrameworkCoreModule),
    typeof(ScheduleTaskEntityFrameworkCoreModule),
    typeof(InstitutionEntityFrameworkCoreModule),
    typeof(PayCenterEntityFrameworkCoreModule)
    )]
public class AbpVnextProEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AbpVnextProEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AbpVnextProDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also AbpVnextProMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });
    }
}
