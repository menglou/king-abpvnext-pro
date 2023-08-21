using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;

namespace King.AbpVnextPro.Notice;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(NoticeDomainSharedModule),
    typeof(AbpAutoMapperModule)
)]
public class NoticeDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<NoticeDomainModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<NotificationDomainAutoMapperProfile>(validate: false);
        });
    }
}
