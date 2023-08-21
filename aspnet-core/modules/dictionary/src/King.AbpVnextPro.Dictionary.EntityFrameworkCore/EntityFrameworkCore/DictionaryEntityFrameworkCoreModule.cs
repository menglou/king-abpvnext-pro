using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

[DependsOn(
    typeof(DictionaryDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class DictionaryEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<DictionaryDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(true);
        });
    }
}
