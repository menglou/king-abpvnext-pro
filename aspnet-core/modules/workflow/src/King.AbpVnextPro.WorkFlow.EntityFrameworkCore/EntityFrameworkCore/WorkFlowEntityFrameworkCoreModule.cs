using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.WorkFlow.EntityFrameworkCore;

[DependsOn(
    typeof(WorkFlowDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class WorkFlowEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<WorkFlowDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
