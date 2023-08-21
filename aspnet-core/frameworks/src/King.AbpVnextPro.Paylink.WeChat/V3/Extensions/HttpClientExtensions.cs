﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using King.AbpVnextPro.Paylink.Security;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Extensions
{
    public static class HttpClientExtensions
    {

#if  NETSTANDARD2_1 || NET5_0_OR_GREATER
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
#else
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
#endif

        public static async Task<(WeChatPayHeaders headers, string body, HttpStatusCode statusCode)> GetAsync<T>(this HttpClient client, IWeChatPayGetRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();

            if (request.GetNeedQueryModel())
            {
                var queryModel = request.GetQueryModel();
                if (queryModel != null)
                {
                    if (url.Contains("?"))
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        url += "&" + WeChatPayUtility.BuildQuery(txtParams);
                    }
                    else
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        url += "?" + WeChatPayUtility.BuildQuery(txtParams);
                    }
                }
            }

            var token = BuildToken(url, "GET", null, options);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var resp = await client.GetAsync(url))
            using (var respContent = resp.Content)
            {
                var headers = GetWeChatPayHeadersFromResponse(resp);
                var body = await respContent.ReadAsStringAsync();
                var statusCode = resp.StatusCode;

                return (headers, body, statusCode);
            }
        }

        public static async Task<(WeChatPayHeaders headers, string body, HttpStatusCode statusCode)> PostAsync<T>(this HttpClient client, IWeChatPayPostRequest<T> request, WeChatPayOptions options) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var bodyModel = request.GetBodyModel();
            if (bodyModel == null)
            {
                throw new WeChatPayException("request.BodyModel is null!");
            }

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            var token = BuildToken(url, "POST", content, options);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/json"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                var headers = GetWeChatPayHeadersFromResponse(resp);
                var body = await respContent.ReadAsStringAsync();
                var statusCode = resp.StatusCode;

                return (headers, body, statusCode);
            }
        }

        public static async Task<(WeChatPayHeaders headers, string body, HttpStatusCode statusCode)> GetAsync<T>(this HttpClient client, IWeChatPayPrivacyGetRequest<T> request, WeChatPayOptions options, string serialNo) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();

            var queryModel = request.GetQueryModel();
            if (queryModel != null)
            {
                if (url.Contains("?"))
                {
                    var txtParams = ConvertToDictionary(queryModel);
                    url += "&" + WeChatPayUtility.BuildQuery(txtParams);
                }
                else
                {
                    var txtParams = ConvertToDictionary(queryModel);
                    url += "?" + WeChatPayUtility.BuildQuery(txtParams);
                }
            }

            var token = BuildToken(url, "GET", null, options);

            client.DefaultRequestHeaders.Add(WeChatPayConsts.Wechatpay_Serial, serialNo);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var resp = await client.GetAsync(url))
            using (var respContent = resp.Content)
            {
                var headers = GetWeChatPayHeadersFromResponse(resp);
                var body = await respContent.ReadAsStringAsync();
                var statusCode = resp.StatusCode;

                return (headers, body, statusCode);
            }
        }

        public static async Task<(WeChatPayHeaders headers, string body, HttpStatusCode statusCode)> PostAsync<T>(this HttpClient client, IWeChatPayPrivacyPostRequest<T> request, WeChatPayOptions options, string serialNo) where T : WeChatPayResponse
        {
            var url = request.GetRequestUrl();
            var bodyModel = request.GetBodyModel();
            if (bodyModel == null)
            {
                throw new WeChatPayException("request.BodyModel is null!");
            }

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            var token = BuildToken(url, "POST", content, options);

            client.DefaultRequestHeaders.Add(WeChatPayConsts.Wechatpay_Serial, serialNo);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("WECHATPAY2-SHA256-RSA2048", token);
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("Unknown")));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var reqContent = new StringContent(content, Encoding.UTF8, "application/json"))
            using (var resp = await client.PostAsync(url, reqContent))
            using (var respContent = resp.Content)
            {
                var headers = GetWeChatPayHeadersFromResponse(resp);
                var body = await respContent.ReadAsStringAsync();
                var statusCode = resp.StatusCode;

                return (headers, body, statusCode);
            }
        }

        private static IDictionary<string, string> ConvertToDictionary(WeChatPayObject obj)
        {
            var utf8Bytes = JsonSerializer.SerializeToUtf8Bytes(obj, obj.GetType(), jsonSerializerOptions);
            var jsonElementParameters = JsonSerializer.Deserialize<IDictionary<string, JsonElement>>(utf8Bytes);

            var txtParameters = new Dictionary<string, string>();
            foreach (var kv in jsonElementParameters)
            {
                switch (kv.Value.ValueKind)
                {
                    case JsonValueKind.Object:
                    case JsonValueKind.Array:
                        txtParameters.Add(kv.Key, kv.Value.GetRawText());
                        continue;
                    case JsonValueKind.String:
                        txtParameters.Add(kv.Key, kv.Value.GetString()!);
                        continue;
                    case JsonValueKind.Number:
                        txtParameters.Add(kv.Key, kv.Value.ToString());
                        continue;
                    case JsonValueKind.True:
                    case JsonValueKind.False:
                        txtParameters.Add(kv.Key, kv.Value.ToString().ToLowerInvariant());
                        continue;
                    case JsonValueKind.Null:
                    case JsonValueKind.Undefined:
                    default:
                        continue;
                }
            }

            return txtParameters;
        }

        private static string BuildToken(string url, string method, string body, WeChatPayOptions options)
        {
            var uri = new Uri(url).PathAndQuery;
            var timestamp = WeChatPayUtility.GetTimeStamp();
            var nonce = WeChatPayUtility.GenerateNonceStr();
            var message = BuildMessage(method, uri, timestamp, nonce, body);
            var signature = SHA256WithRSA.Sign(options.RSAPrivateKey, message);

            return $"mchid=\"{options.MchId}\",nonce_str=\"{nonce}\",timestamp=\"{timestamp}\",serial_no=\"{options.CertificateSerialNo}\",signature=\"{signature}\"";
        }

        private static string BuildMessage(string method, string uri, string timestamp, string nonce, string body)
        {
            return $"{method}\n{uri}\n{timestamp}\n{nonce}\n{body}\n";
        }

        private static WeChatPayHeaders GetWeChatPayHeadersFromResponse(HttpResponseMessage response)
        {
            var headers = new WeChatPayHeaders();

            if (response.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Serial, out var serialValues))
            {
                headers.Serial = serialValues.First();
            }

            if (response.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Timestamp, out var timestampValues))
            {
                headers.Timestamp = timestampValues.First();
            }

            if (response.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Nonce, out var nonceValues))
            {
                headers.Nonce = nonceValues.First();
            }

            if (response.Headers.TryGetValues(WeChatPayConsts.Wechatpay_Signature, out var signatureValues))
            {
                headers.Signature = signatureValues.First();
            }

            return headers;
        }
    }
}
