using King.AbpVnextPro.File.Files;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

[DependsOn(
    typeof(FileDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class FileEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<FileDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddRepository<Files.File, EfCoreFileRepository>();
        });
    }
}
