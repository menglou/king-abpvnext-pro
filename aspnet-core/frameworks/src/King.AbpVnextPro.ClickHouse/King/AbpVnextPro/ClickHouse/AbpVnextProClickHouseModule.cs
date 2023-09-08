using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.ClickHouse.King.AbpVnextPro.ClickHouse
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AbpVnextProClickHouseModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
