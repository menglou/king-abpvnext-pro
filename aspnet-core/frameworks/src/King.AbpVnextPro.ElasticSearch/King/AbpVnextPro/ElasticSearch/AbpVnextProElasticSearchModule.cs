
namespace King.AbpVnextPro.ElasticSearch;

[DependsOn(typeof(AbpAutofacModule))]
public class AbpVnextProElasticSearchModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.Configure<AbpVnextProElasticSearchOptions>(context.Services.GetConfiguration().GetSection("ElasticSearch"));
    }
}