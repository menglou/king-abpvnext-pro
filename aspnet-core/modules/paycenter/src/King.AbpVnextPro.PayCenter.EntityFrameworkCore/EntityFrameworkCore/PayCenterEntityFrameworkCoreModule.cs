using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.PayCenter.EntityFrameworkCore;

[DependsOn(
    typeof(PayCenterDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class PayCenterEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<PayCenterDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
