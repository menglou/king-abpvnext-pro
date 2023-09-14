using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.FreeRedis.King.AbpVnextPro.FreeRedis
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AbpVnextProFreeRedisModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<AbpVnextProFreeRedisOptions>(context.Services.GetConfiguration().GetSection("FreeRedis"));
        }
    }
}
