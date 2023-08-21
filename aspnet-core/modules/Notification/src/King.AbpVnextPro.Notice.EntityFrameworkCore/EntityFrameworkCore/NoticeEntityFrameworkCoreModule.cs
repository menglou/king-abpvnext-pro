using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

[DependsOn(
    typeof(NoticeDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class NoticeEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<NoticeDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(true);
        });
    }
}
