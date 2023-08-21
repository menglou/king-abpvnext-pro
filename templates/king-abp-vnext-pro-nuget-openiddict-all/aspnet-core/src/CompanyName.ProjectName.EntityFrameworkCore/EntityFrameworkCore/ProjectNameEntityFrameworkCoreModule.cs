using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Uow;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using King.AbpVnextPro.Openiddict.EntityFrameworkCore;
using King.AbpVnextPro.Notice.EntityFrameworkCore;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Dictionary.EntityFrameworkCore;
using King.AbpVnextPro.File.EntityFrameworkCore;
using King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;
using King.AbpVnextPro.Institution.EntityFrameworkCore;
using King.AbpVnextPro.PayCenter.EntityFrameworkCore;

namespace CompanyName.ProjectName.EntityFrameworkCore;

[DependsOn(
    typeof(ProjectNameDomainModule),
    typeof(AbpOpenIddictEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(OpeniddictEntityFrameworkCoreModule),
    typeof(NoticeEntityFrameworkCoreModule),
    typeof(DictionaryEntityFrameworkCoreModule),
    typeof(FileEntityFrameworkCoreModule),
    typeof(ScheduleTaskEntityFrameworkCoreModule),
     typeof(InstitutionEntityFrameworkCoreModule),
    typeof(PayCenterEntityFrameworkCoreModule)
    )]
public class ProjectNameEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        ProjectNameEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ProjectNameDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also ProjectNameMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });

    }
}
