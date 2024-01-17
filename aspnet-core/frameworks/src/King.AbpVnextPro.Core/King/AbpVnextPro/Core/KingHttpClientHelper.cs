using ICSharpCode.SharpZipLib.GZip;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Core
{
    public class KingHttpClientHelper
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private ILogger<KingHttpClientHelper> _logger;
        public KingHttpClientHelper(IHttpClientFactory httpClientFactory, ILogger<KingHttpClientHelper> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }
        #region http 请求方式
        /// <summary>
        /// 使用post方法异步请求 
        /// </summary>
        /// <param name="url">目标链接</param>
        /// <param name="posData">发送的参数JSON字符串</param>
        /// <param name="header">请求头</param>
        /// <param name="posFrom">表单提交格式</param>
        /// <param name="gzip">是否压缩</param>
        /// <returns>返回的字符串</returns>
        public async Task<string> PostAsync(string url, string posData, Dictionary<string, string> header = null, Dictionary<string, string> posFrom = null, bool gzip = false)
        {

            //从工厂获取请求对象
            var client = _httpClientFactory.CreateClient();
            //消息状态
            string responseBody = string.Empty;
            //存在则是表单提交信息
            if (posFrom != null)
            {
                var formData = new MultipartFormDataContent();
                foreach (var item in posFrom)
                {
                    formData.Add(new StringContent(item.Value), item.Key);
                }
                //提交信息
                var result = await client.PostAsync(url, formData);
                _logger.LogInformation($"调用接口后返回的结果{result}");
                if (!result.IsSuccessStatusCode)
                {
                    return null;
                }
                //获取消息状态
                responseBody = await result.Content.ReadAsStringAsync();
            }
            else
            {
                HttpContent content = new StringContent(posData);
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                _logger.LogInformation($"调用接口后返回的结果{response}");
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                //response.EnsureSuccessStatusCode();
                if (gzip)
                {
                    GZipInputStream inputStream = new GZipInputStream(await response.Content.ReadAsStreamAsync());
                    responseBody = new StreamReader(inputStream).ReadToEnd();
                }
                else
                {
                    responseBody = await response.Content.ReadAsStringAsync();
                    _logger.LogInformation($"调用接口后返回的结果内容{response}");

                }
            }

            return responseBody;

        }

        /// <summary>
        /// 使用get方法异步请求
        /// </summary>
        /// <param name="url">目标链接</param>
        /// <param name="header"></param>
        /// <param name="Gzip"></param>
        /// <returns>返回的字符串</returns>
        public async Task<string> GetAsync(string url, Dictionary<string, string> header = null, bool Gzip = false)
        {
            var client = _httpClientFactory.CreateClient();
            //HttpClient client = new HttpClient(new HttpClientHandler() { UseCookies = false });
            if (header != null)
            {
                client.DefaultRequestHeaders.Clear();
                foreach (var item in header)
                {
                    client.DefaultRequestHeaders.Add(item.Key, item.Value);
                }
            }
            HttpResponseMessage response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            //response.EnsureSuccessStatusCode();//用来抛异常
            string responseBody = "";
            if (Gzip)
            {
                GZipInputStream inputStream = new GZipInputStream(await response.Content.ReadAsStreamAsync());
                responseBody = new StreamReader(inputStream).ReadToEnd();
            }
            else
            {
                responseBody = await response.Content.ReadAsStringAsync();

            }
            return responseBody;
        }

        /// <summary>
        /// 使用post返回异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <typeparam name="T2">请求对象类型</typeparam>
        /// <param name="url">请求链接</param>
        /// <param name="obj">请求对象数据</param>
        /// <param name="header">请求头</param>
        /// <param name="postFrom">表单提交 表单提交 注* postFrom不为null 代表表单提交, 为null标识惊悚格式请求</param>
        /// <param name="gzip">是否压缩</param>
        /// <returns>请求返回的目标对象</returns>
        public async Task<T> PostObjectAsync<T, T2>(string url, T2 obj, Dictionary<string, string> header = null, Dictionary<string, string> postFrom = null, bool gzip = false, bool replace = false)
        {
            String json = JsonConvert.SerializeObject(obj);
            string responseBody = await PostAsync(url, json, header, postFrom, gzip); //请求当前账户的信息
            object jsons = null;
            string resstr = string.Empty;
            if (responseBody is null)
            {
                return default(T);
            }
            else
            {
                if (replace == true)
                {
                    // string filterstr = responseBody.Replace("HTTP/1.1 200 \\r\\n", "");
                    jsons = new Newtonsoft.Json.JsonSerializer().Deserialize(new JsonTextReader(new StringReader(responseBody)));
                    if (jsons.ToString().Contains("HTTP/1.1 200"))
                    {
                        resstr = Regex.Replace(jsons.ToString().Replace("HTTP/1.1 200 ", ""), @"[\r\n]", "");
                    }
                    else if (jsons.ToString().Contains("HTTP/1.1 201"))
                    {
                        resstr = Regex.Replace(jsons.ToString().Replace("HTTP/1.1 201 ", ""), @"[\r\n]", "");
                    }

                }
                else
                {
                    resstr = responseBody;
                }
            }
            return JsonConvert.DeserializeObject<T>(resstr);//把收到的字符串序列化
        }

        /// <summary>
        /// 使用Get返回异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">请求对象类型</typeparam>
        /// <param name="url">请求链接</param>
        /// <returns>返回请求的对象</returns>
        public async Task<T> GetObjectAsync<T>(string url)
        {
            string responseBody = await GetAsync(url); //请求当前账户的信息
            if (responseBody is null)
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(responseBody);//把收到的字符串序列化
        }

        #endregion
    }
}
