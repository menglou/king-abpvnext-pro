using FreeRedis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro.FreeRedis.King.AbpVnextPro.FreeRedis
{
    public abstract class FreeRedisRepository : IFreeRedisRepository, ITransientDependency
    {
        protected abstract int DB { get; }

        private readonly IFreeRedisProvider _freeRedisProvider;

        public FreeRedisRepository(IFreeRedisProvider freeRedisProvider)
        {
            _freeRedisProvider = freeRedisProvider;
        }
        protected IRedisClient Client => _freeRedisProvider.GetClient(DB);


        #region String
        /// <summary>
        /// 设置单个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual async Task<bool> StringSetAsync<T>(string key, T value)
        {
            try
            {
                await Client.SetAsync<T>(key, value);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        /// <summary>
        /// 设置多个
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public virtual async Task<bool> MStringSetAsync<T>(Dictionary<string, T> keyValues)
        {
            try
            {
                await Client.MSetAsync<T>(keyValues);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }

        }

        /// <summary>
        /// 设置单个 带锁的 key-vaaue  通常 要配合过期时间使用，否则
        /// 在加锁后发生宕机或异常退出，无法正常执行锁的释放操作，导致其他进程无法获取该锁，
        /// 从而产生死锁现象。这会对系统的可用性和响应性造成严重影
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public virtual async Task<bool> StringSetNxAsync<T>(string key, T value, int expiry)
        {
            try
            {
                await Client.SetExAsync<T>(key, expiry, value);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }

        /// <summary>
        /// 设置单个带过期日期的
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public virtual async Task<bool> StringSetAsync<T>(string key, T value, int expiry = default(int))
        {
            try
            {
                await Client.SetAsync<T>(key, value, expiry);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }

        }
        /// <summary>
        /// 根据key 获取单个value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual async Task<T> StringGetAsync<T>(string key)
        {
            try
            {
                return await Client.GetAsync<T>(key);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        /// <summary>
        /// 根据多个 key  获取多个值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keys"></param>
        /// <returns></returns>
        public virtual async Task<T[]> MStringGetAsync<T>(params string[] keys)
        {
            try
            {
                return await Client.MGetAsync<T>(keys);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }

        }
        /// <summary>
        /// 根据key 删除 value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public virtual async Task<bool> StringDelAsync(string key)
        {
            try
            {
                await Client.DelAsync(key);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        /// <summary>
        /// 根据key 判断存不存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public virtual async Task<bool> StringExitsAsync(string key)
        {
            try
            {
                return await Client.ExistsAsync(key);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        /// <summary>
        /// 根据key 判断存不存在,如果不存在就写入
        /// </summary>
        /// <param name="key"></param>
        /// <param name="valaue"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        /// <exception cref="BusinessException"></exception>
        public virtual async Task<bool> StringExitsAndSetAsync<T>(string key, T valaue, int expiry = default(int))
        {
            try
            {
                if (!await Client.ExistsAsync(key))
                {
                    await Client.SetAsync(key, valaue, expiry);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        #endregion

        #region Hash
        /// <summary>
        /// 设置单个对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual async Task HashSetAsync<T>(string key, string field, T value)
        {
            try
            {
                await Client.HSetAsync(key, field, value);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException:ex);
            }
            
        }
        /// <summary>
        /// 设置 带锁的 单个对象，如果设置成功可以证明获取所成功，否则就是失败 
        /// 通常这个要配个 HDelete一起使用 用来释放锁
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public virtual async Task<bool> HashSetNxAsync<T>(string key, string field, T value)
        {
            try
            {
                //设置互斥
                return await Client.HSetNxAsync<T>(key, field, value);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException:ex);
            }
           
        }
        /// <summary>
        /// 设置 带锁的 并且又过期时间 单个对象，如果设置成功可以证明获取所成功，否则就是失败 
        /// 通常这个要配个 HDelete一起使用 用来释放锁
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="expiry"></param>
        /// <returns></returns>
        public virtual async Task<bool> HashSetNxAsync<T>(string key, string field, T value, int expiry = default(int))
        {
            try
            {
                //设置互斥
                await Client.HSetNxAsync<T>(key, field, value);
                //设置过期时间
                await Client.SetXxAsync<T>(key, value, expiry);

                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
        }
        /// <summary>
        /// 根据key 对象属性名获取 value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public virtual async Task<T> HashGetAsync<T>(string key, string field)
        {
            try
            {
               return await Client.HGetAsync<T>(key, field);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
           
        }
        /// <summary>
        /// 根据key 和 对象属性名删除 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public virtual async Task<bool> HashDelAsync<T>(string key, params string[] field)
        {
            try
            {
                await Client.HDelAsync(key, field);
                return true;
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
            
        }
        /// <summary>
        /// 根据 key 和 对象属性名 判断存不存在
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public virtual async Task<bool> HashExitsAsync<T>(string key, string field)
        {
            try
            {
                return await Client.HExistsAsync(key, field);
            }
            catch (Exception ex)
            {
                throw new BusinessException(innerException: ex);
            }
            
        }
        #endregion

        #region List
        public virtual async Task LPushListAsync<T>(string key, params object[]emelemts)
        {
            await Client.LPushAsync(key, emelemts);
        }
        public virtual async Task RPushListAsync<T>(string key, params object[] emelemts)
        {
            await Client.RPushAsync(key, emelemts);
        }
        #endregion

        #region Set
        public virtual async Task SetAddAsync<T>(string key, params object[] members)
        {
            await Client.SAddAsync(key, members);
        }
       
        #endregion

        #region ZSet
        
        #endregion
    }
}
