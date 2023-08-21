using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace King.AbpVnextPro.IdentityServer.MongoDB;

[DependsOn(
    typeof(IdentityServerDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class IdentityServerMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<IdentityServerMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
