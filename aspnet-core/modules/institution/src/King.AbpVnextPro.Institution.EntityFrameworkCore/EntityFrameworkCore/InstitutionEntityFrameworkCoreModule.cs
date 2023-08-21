using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Posters;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

[DependsOn(
    typeof(InstitutionDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class InstitutionEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<InstitutionDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddRepository<DepartmentUnit, EfCoreDepartmentUnitRepository>();
            options.AddRepository<Poster, EfCorePosterRepository>();
        });
    }
}
