using FreeRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.FreeRedis.King.AbpVnextPro.FreeRedis
{
    public interface IFreeRedisProvider
    {
        IRedisClient GetClient(int db);
    }
}
