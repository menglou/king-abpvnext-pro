using FreeRedis;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro.FreeRedis.King.AbpVnextPro.FreeRedis
{
    public class FreeRedisProvider : IFreeRedisProvider, ITransientDependency
    {
        private readonly AbpVnextProFreeRedisOptions _options;

        public FreeRedisProvider(IOptions<AbpVnextProFreeRedisOptions> options)
        {
            _options = options.Value;
        }
        public virtual IRedisClient GetClient(int db)
        {
            var redisClient = new RedisClient($"{_options.Host},password={_options.Password},defaultDatabase={Convert.ToInt32 (db)}");
            return redisClient;
        }
    }
}
