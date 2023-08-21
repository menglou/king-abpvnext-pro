using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Paylink.WeChat
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AbpVnextProPaylinkWeChatModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddWeChatPay();
            context.Services.AddSingleton<IGetWeChatSettingService, GetWeChatSettingService>();
        }
    }
}
