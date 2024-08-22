using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.FreeRedis.King.AbpVnextPro.FreeRedis
{
    public interface IFreeRedisRepository
    {
        Task<bool> StringSetAsync<T>(string key, T value);
        Task<bool> MStringSetAsync<T>(Dictionary<string, T> keyValues);
        Task<bool> StringSetNxAsync<T>(string key, T value, int expiry);
        Task<bool> StringSetAsync<T>(string key, T value, int expiry = default(int));
        Task<T> StringGetAsync<T>(string key);
        Task<T[]> MStringGetAsync<T>(params string[] keys);
        Task<bool> StringDelAsync(string key);
        Task<bool> StringExitsAsync(string key);
        Task<bool> StringExitsAndSetAsync<T>(string key, T valaue, int expiry = default(int));

        Task HashSetAsync<T>(string key, string field, T value);
        Task<bool> HashSetNxAsync<T>(string key, string field, T value);
        Task<bool> HashSetNxAsync<T>(string key, string field, T value, int expiry = default(int));
        Task<T> HashGetAsync<T>(string key, string field);
        Task<bool> HashDelAsync<T>(string key, params string[] field);
        Task<bool> HashExitsAsync<T>(string key, string field);
        Task LPushListAsync<T>(string key, params object[] emelemts);
        Task RPushListAsync<T>(string key, params object[] emelemts);
        Task SetAddAsync<T>(string key, params object[] members);
    }
}
