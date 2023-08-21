using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Microsoft.Extensions.Configuration;
using Volo.Abp.Settings;
using King.AbpVnextPro.PayCenter.Settings;
using Volo.Abp.DependencyInjection;
using King.AbpVnextPro.PayCenter.PayCenter;
using JetBrains.Annotations;
using Volo.Abp;
using King.AbpVnextPro.Paylink.Alipy;
using King.AbpVnextPro.Paylink.WeChat;

namespace King.AbpVnextPro.PayCenter;

[DependsOn(
    typeof(PayCenterDomainModule),
    typeof(PayCenterApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpSettingsModule),
    typeof(AbpVnextProPaylinkAlipayModule),
    typeof(AbpVnextProPaylinkWeChatModule)
    )]
public class PayCenterApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PayCenterApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<PayCenterApplicationModule>(validate: true);
        });
      

    }

    public override Task OnApplicationInitializationAsync(ApplicationInitializationContext context)
    {
        return base.OnApplicationInitializationAsync(context);

    }
}
