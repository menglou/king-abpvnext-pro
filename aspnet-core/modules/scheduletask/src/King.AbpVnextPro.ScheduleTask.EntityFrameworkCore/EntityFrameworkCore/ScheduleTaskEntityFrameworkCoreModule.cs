using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

[DependsOn(
    typeof(ScheduleTaskDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ScheduleTaskEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ScheduleTaskDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(true);
            options.AddRepository<ScheduleEntity, EfCoreScheduleEntityRepository>();
            options.AddRepository<ScheduleHttpOptionEntity, EfCoreScheduleHttpOptionEntityRepository>();
            options.AddRepository<ScheduleKeeperEntity, EfCoreScheduleKeeperEntityRepository>();
            options.AddRepository<ScheduleLogEntity, EfCoreScheduleLogEntityRepository>();
        });
    }
}
