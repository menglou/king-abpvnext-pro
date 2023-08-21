using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace King.AbpVnextPro.Institution;

[DependsOn(
    typeof(InstitutionDomainModule),
    typeof(InstitutionApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class InstitutionApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<InstitutionApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<InstitutionApplicationModule>(validate: false);
        });
    }
}
