using FreeSql;
using FreeSql.ClickHouse;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro.ClickHouse.King.AbpVnextPro.ClickHouse
{
    public class ClickHouseProvider: IClickHouseProvider, ISingletonDependency
    {
        private readonly IConfiguration _configuration;
        public ClickHouseProvider(IConfiguration configuration)
        {
            _configuration=configuration;
        }
        public virtual IFreeSql GetClient()
        {
           var fsql = new FreeSqlBuilder().UseConnectionString(DataType.ClickHouse, _configuration.GetSection("ClickHouse:Default").Value.ToString())
                     .UseAutoSyncStructure(false) //自动同步实体结构到数据库
                     .Build(); //请务必定义成 Singleton 单例模式
            return fsql;
        }
    }
}
