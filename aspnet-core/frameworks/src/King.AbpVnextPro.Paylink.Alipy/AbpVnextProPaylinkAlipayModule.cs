using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Paylink.Alipy
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AbpVnextProPaylinkAlipayModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAlipay();
            context.Services.AddSingleton<IGetAlipaySettingService, GetAlipaySettingService>();
        }
    }
}
