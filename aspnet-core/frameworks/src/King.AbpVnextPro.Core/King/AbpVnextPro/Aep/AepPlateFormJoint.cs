using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace King.AbpVnextPro.Core.King.AbpVnextPro.Aep
{
    /// <summary>
    /// aep 平台 第三方接口对接
    /// </summary>
    public class AepPlateFormJoint
    {
        /// <summary>
        /// 创建header
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="param"></param>
        /// <param name="body"></param>
        /// <param name="version"></param>
        /// <param name="application"></param>
        /// <param name="key"></param>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Dictionary<string, string> CreateCommandLwm2mProfile(Dictionary<string, string> headers, Dictionary<string, string> param, string body, string version, string application, string key, ref string url)
        {

            string paramString = "";

            if (param != null)
            {
                foreach (KeyValuePair<string, string> kvp in param)
                {
                    paramString += kvp.Key + "=" + kvp.Value + "&";
                }
            }

            if (paramString.Length > 0)
            {
                paramString = paramString.Remove(paramString.Length - 1);
            }

            Dictionary<string, string> paramTmp = new Dictionary<string, string>();
            if (headers != null)
                paramTmp = paramTmp.Concat(headers).ToDictionary(k => k.Key, v => v.Value);
            if (param != null)
                paramTmp = paramTmp.Concat(param).ToDictionary(k => k.Key, v => v.Value);

            long curentTime = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;

            long timestamp = curentTime;

            Dictionary<string, string> headersTmp = new Dictionary<string, string>();
            headersTmp.Add("application", application);
            headersTmp.Add("timestamp", "" + timestamp);
            headersTmp.Add("version", version);
            //headersTmp.Add("Content-Type", "application/json; charset=UTF-8");
            //headersTmp.Add("Date", dataString);
            headersTmp.Add("signature", Sign(paramTmp, timestamp, application, key, body));
            if (headers != null)
            {
                headersTmp = headersTmp.Concat(headers).ToDictionary(k => k.Key, v => v.Value);
            }

            if (paramString.Length > 0)
            {
                url += "?" + paramString;
            }

            return headersTmp;
        }


        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="param">api接口参数</param>
        /// <param name="timestamp">时间戳，毫秒级</param>
        /// <param name="application">App Key</param>
        /// <param name="secret">App secret</param>
        /// <param name="body">body</param>
        /// <returns></returns>
        public static string Sign(Dictionary<string, string> param, long timestamp, string application, string secret, string body)
        {
            // 连接系统参数
            string temp = "application:" + application + "\n";
            temp += "timestamp:" + timestamp + "\n";

            // 连接请求参数
            if (param != null)
            {
                var dicNew = param.OrderBy(x => x.Key, new ComparerString()).ToDictionary(x => x.Key, y => y.Value);

                foreach (KeyValuePair<string, string> kvp in dicNew)
                {
                    temp += kvp.Key + ":" + (kvp.Value == null ? "" : kvp.Value) + "\n";
                }
            }


            // 得到需要签名的字符串
            if (body != null && body.Length > 0)
            {
                temp += body + "\n";
            }

            // hmac-sha1编码
            var hmacsha1 = new HMACSHA1();
            hmacsha1.Key = Encoding.UTF8.GetBytes(secret);
            byte[] dataBuffer = Encoding.UTF8.GetBytes(temp);
            byte[] hashBytes = hmacsha1.ComputeHash(dataBuffer);


            // base64编码
            string encode = Convert.ToBase64String(hashBytes);

            return encode;
        }

        public static string SendHttpRequest(string url, Dictionary<string, string> headers, string contentType, string method, string dataStream, int timeout, out WebHeaderCollection head)
        {
            GC.Collect();//垃圾回收，回收没有正常关闭的http链接
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream reqStream = null;
            try
            {
                //设置最大链接数
                ServicePointManager.DefaultConnectionLimit = 200;
                //设置https验证方式
                if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback =
                            new RemoteCertificateValidationCallback(CertificateValidation);
                }
                request = (HttpWebRequest)WebRequest.Create(url);

                //HttpWebRequest 相关属性
                request.Method = method;
                request.Timeout = timeout * 1000;
                request.ContentType = contentType;
                if (headers != null)
                {
                    //配置协议标头
                    foreach (KeyValuePair<string, string> kvp in headers)
                    {
                        request.Headers.Add(kvp.Key, kvp.Value);
                    }
                }

                byte[] data = null;
                if (dataStream != null)
                {
                    data = Encoding.UTF8.GetBytes(dataStream);
                    request.ContentLength = data.Length;
                }

                if (data != null)
                {
                    //写入数据
                    reqStream = request.GetRequestStream();
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }

                head = null;
                //返回数据
                response = (HttpWebResponse)request.GetResponse();
                if (response != null)
                {
                    head = response.Headers;
                    Stream stream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                    string result = sr.ReadToEnd();
                    sr.Close();
                    //关闭连接和流
                    response.Close();
                    return result;
                }
                else
                {
                    head = null;
                    return String.Empty;
                }


            }
            //处理多线程模式下线程中止
            //catch (System.Threading.ThreadAbortException e)
            //{
            //    System.Threading.Thread.ResetAbort();
            //}
            catch (WebException e)
            {
                head = null;
                response = (HttpWebResponse)e.Response;
                if (response != null)
                {
                    head = response.Headers;
                }
                throw e;
            }
            catch (Exception e)
            {
                throw new HttpServiceException(e.ToString());
            }
            finally
            {
                if (request != null)
                {
                    request.Abort();
                }
            }
        }


        private static bool CertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            // 认证正常，没有错误   
            return true;
        }
    }

    public class ComparerString : IComparer<String>
    {
        public int Compare(String x, String y)
        {
            return string.CompareOrdinal(x, y);
        }
    }

    public class HttpServiceException : Exception
    {
        public HttpServiceException(string msg) : base(msg)
        {

        }
    }
}
