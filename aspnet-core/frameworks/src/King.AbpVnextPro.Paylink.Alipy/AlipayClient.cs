﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using King.AbpVnextPro.Paylink.Alipy.Extensions;
using King.AbpVnextPro.Paylink.Alipy.Parser;
using King.AbpVnextPro.Paylink.Alipy.Utility;

namespace King.AbpVnextPro.Paylink.Alipy
{
    public class AlipayClient : IAlipayClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly AlipayPublicKeyManager _publicKeyManager;

        #region AlipayClient Constructors

        public AlipayClient(IHttpClientFactory httpClientFactory, AlipayPublicKeyManager publicKeyManager)
        {
            _httpClientFactory = httpClientFactory;
            _publicKeyManager = publicKeyManager;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await PageExecuteAsync(request, options, null, "POST");
        }

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string reqMethod) where T : AlipayResponse
        {
            return await PageExecuteAsync(request, options, accessToken, null, reqMethod);
        }

        public async Task<T> PageExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string reqMethod) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppPrivateKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.ServerUrl)} is Empty!");
            }

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { AlipayConstants.METHOD, request.GetApiName() },
                { AlipayConstants.VERSION, apiVersion },
                { AlipayConstants.APP_ID, options.AppId },
                { AlipayConstants.FORMAT, options.Format },
                { AlipayConstants.TIMESTAMP, DateTime.Now },
                { AlipayConstants.ACCESS_TOKEN, accessToken },
                { AlipayConstants.APP_AUTH_TOKEN, appAuthToken },
                { AlipayConstants.SIGN_TYPE, options.SignType },
                { AlipayConstants.TERMINAL_TYPE, request.GetTerminalType() },
                { AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo() },
                { AlipayConstants.PROD_CODE, request.GetProdCode() },
                { AlipayConstants.NOTIFY_URL, request.GetNotifyUrl() },
                { AlipayConstants.CHARSET, options.Charset },
                { AlipayConstants.RETURN_URL, request.GetReturnUrl() },
                { AlipayConstants.ALIPAY_ROOT_CERT_SN, options.AlipayRootCertSN },
                { AlipayConstants.APP_CERT_SN, options.AppCertSN }
            };

            //字典排序
            var sortedTxtParams = new SortedDictionary<string, string>(txtParams, StringComparer.Ordinal);
            txtParams = new AlipayDictionary(sortedTxtParams);

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(AlipayConstants.SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            string body;

            // 是否需要上传文件
            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                var client = _httpClientFactory.CreateClient(nameof(AlipayClient));
                body = await client.PostAsync(options.ServerUrl + "?" + AlipayConstants.CHARSET + "=" + options.Charset, txtParams, fileParams);
            }
            else
            {
                if (reqMethod.ToUpperInvariant() == "GET")
                {
                    var url = options.ServerUrl;
                    if (txtParams.Count > 0)
                    {
                        if (url.Contains("?"))
                        {
                            url += "&" + AlipayUtility.BuildQuery(txtParams);
                        }
                        else
                        {
                            url += "?" + AlipayUtility.BuildQuery(txtParams);
                        }
                    }
                    body = url;
                }
                else
                {
                    body = BuildHtmlRequest(txtParams, options.ServerUrl, reqMethod);
                }
            }

            var parser = new AlipayJsonParser<T>();
            var rsp = parser.Parse(body);

            return rsp;
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await ExecuteAsync(request, options, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse
        {
            return await ExecuteAsync(request, options, accessToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            return await ExecuteAsync(request, options, accessToken, appAuthToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string targetAppId) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (!string.IsNullOrEmpty(options.AppPublicCert) || !string.IsNullOrEmpty(options.AlipayPublicCert) || !string.IsNullOrEmpty(options.AlipayRootCert))
            {
                throw new AlipayException("检测到证书相关参数已初始化，证书模式下请改为调用CertificateExecuteAsync。");
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AlipayPublicKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AlipayPublicKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppPrivateKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.ServerUrl)} is Empty!");
            }

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { AlipayConstants.METHOD, request.GetApiName() },
                { AlipayConstants.VERSION, apiVersion },
                { AlipayConstants.APP_ID, options.AppId },
                { AlipayConstants.FORMAT, options.Format },
                { AlipayConstants.TIMESTAMP, DateTime.Now },
                { AlipayConstants.ACCESS_TOKEN, accessToken },
                { AlipayConstants.SIGN_TYPE, options.SignType },
                { AlipayConstants.TERMINAL_TYPE, request.GetTerminalType() },
                { AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo() },
                { AlipayConstants.PROD_CODE, request.GetProdCode() },
                { AlipayConstants.CHARSET, options.Charset }
            };

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            }

            if (!string.IsNullOrEmpty(targetAppId))
            {
                txtParams.Add(AlipayConstants.TARGET_APP_ID, targetAppId);
            }

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(txtParams[AlipayConstants.BIZ_CONTENT]))
                {
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncryptKey) || string.IsNullOrEmpty(options.EncryptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncryptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipaySignature.AESEncrypt(txtParams[AlipayConstants.BIZ_CONTENT], options.EncryptKey);
                txtParams.Remove(AlipayConstants.BIZ_CONTENT);
                txtParams.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                txtParams.Add(AlipayConstants.ENCRYPT_TYPE, options.EncryptType);
            }

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(AlipayConstants.SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            string body;
            var client = _httpClientFactory.CreateClient(nameof(AlipayClient));

            // 是否需要上传文件
            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                body = await client.PostAsync(options.ServerUrl + "?" + AlipayConstants.CHARSET + "=" + options.Charset, txtParams, fileParams);
            }
            else
            {
                body = await client.PostAsync(options.ServerUrl + "?" + AlipayConstants.CHARSET + "=" + options.Charset, txtParams);
            }

            var parser = new AlipayJsonParser<T>();
            var item = ParseRespItem(request, body, parser, options.EncryptKey, options.EncryptType);
            var rsp = parser.Parse(item.RealContent);

            CheckResponseSign(request, item.RespContent, rsp.IsError, parser, options);

            return rsp;
        }

        private static void CheckResponseSign<T>(IAlipayRequest<T> request, string body, bool isError, IAlipayParser<T> parser, AlipayOptions options) where T : AlipayResponse
        {
            var signItem = parser.GetSignItem(request, body);
            if (signItem == null)
            {
                throw new AlipayException("sign check fail: Body)} is Empty!");
            }

            if (!isError || !string.IsNullOrEmpty(signItem.Sign))
            {
                var rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceData, signItem.Sign, options.AlipayPublicKey, options.SignType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(signItem.SignSourceData) && signItem.SignSourceData.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceData.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, options.AlipayPublicKey, options.SignType);
                        if (!jsonCheck)
                        {
                            throw new AlipayException("sign check fail: check Sign and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AlipayException("sign check fail: check Sign and Data Fail!");
                    }
                }
            }
        }

        #endregion

        #region IAlipayClient Members

        public async Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await CertificateExecuteAsync(request, options, null);
        }

        public async Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken) where T : AlipayResponse
        {
            return await CertificateExecuteAsync(request, options, accessToken, null);
        }

        public async Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken) where T : AlipayResponse
        {
            return await CertificateExecuteAsync(request, options, accessToken, appAuthToken, null);
        }

        public async Task<T> CertificateExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string accessToken, string appAuthToken, string targetAppId) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppPublicCert) || string.IsNullOrEmpty(options.AlipayPublicCert) || string.IsNullOrEmpty(options.AlipayRootCert))
            {
                throw new AlipayException("检测到证书相关参数未初始化，非证书模式下请改为调用ExecuteAsync。");
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppPrivateKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPublicCert))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppPublicCert)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AlipayPublicCert))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AlipayPublicCert)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AlipayRootCert))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AlipayRootCert)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.ServerUrl)} is Empty!");
            }

            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var txtParams = new AlipayDictionary(request.GetParameters())
            {
                { AlipayConstants.METHOD, request.GetApiName() },
                { AlipayConstants.VERSION, apiVersion },
                { AlipayConstants.APP_ID, options.AppId },
                { AlipayConstants.FORMAT, options.Format },
                { AlipayConstants.TIMESTAMP, DateTime.Now },
                { AlipayConstants.ACCESS_TOKEN, accessToken },
                { AlipayConstants.SIGN_TYPE, options.SignType },
                { AlipayConstants.TERMINAL_TYPE, request.GetTerminalType() },
                { AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo() },
                { AlipayConstants.PROD_CODE, request.GetProdCode() },
                { AlipayConstants.CHARSET, options.Charset },
                { AlipayConstants.APP_CERT_SN, options.AppCertSN },
                { AlipayConstants.ALIPAY_ROOT_CERT_SN, options.AlipayRootCertSN }
            };

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
            {
                txtParams.Add(AlipayConstants.NOTIFY_URL, request.GetNotifyUrl());
            }

            if (!string.IsNullOrEmpty(appAuthToken))
            {
                txtParams.Add(AlipayConstants.APP_AUTH_TOKEN, appAuthToken);
            }

            if (!string.IsNullOrEmpty(targetAppId))
            {
                txtParams.Add(AlipayConstants.TARGET_APP_ID, targetAppId);
            }

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(txtParams[AlipayConstants.BIZ_CONTENT]))
                {
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncryptKey) || string.IsNullOrEmpty(options.EncryptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncryptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipaySignature.AESEncrypt(txtParams[AlipayConstants.BIZ_CONTENT], options.EncryptKey);
                txtParams.Remove(AlipayConstants.BIZ_CONTENT);
                txtParams.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                txtParams.Add(AlipayConstants.ENCRYPT_TYPE, options.EncryptType);
            }

            // 添加签名参数
            var signContent = AlipaySignature.GetSignContent(txtParams);
            txtParams.Add(AlipayConstants.SIGN, AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType));

            string body;
            var client = _httpClientFactory.CreateClient(nameof(AlipayClient));

            // 是否需要上传文件
            if (request is IAlipayUploadRequest<T> uRequest)
            {
                var fileParams = AlipayUtility.CleanupDictionary(uRequest.GetFileParameters());

                body = await client.PostAsync(options.ServerUrl + "?" + AlipayConstants.CHARSET + "=" + options.Charset, txtParams, fileParams);
            }
            else
            {
                body = await client.PostAsync(options.ServerUrl + "?" + AlipayConstants.CHARSET + "=" + options.Charset, txtParams);
            }

            var parser = new AlipayJsonParser<T>();
            var item = ParseRespItem(request, body, parser, options.EncryptKey, options.EncryptType);
            var rsp = parser.Parse(item.RealContent);

            await CheckResponseCertSignAsync(request, item.RespContent, rsp.IsError, parser, options);

            return rsp;
        }

        private async Task CheckResponseCertSignAsync<T>(IAlipayRequest<T> request, string body, bool isError, IAlipayParser<T> parser, AlipayOptions options) where T : AlipayResponse
        {
            if (request is AlipayOpenAppAlipaycertDownloadRequest)
            {
                return;
            }

            var certItem = parser.GetCertItem(request, body);
            if (certItem == null)
            {
                throw new AlipayException("cert check fail: Body)} is Empty!");
            }

            if (!isError || !string.IsNullOrEmpty(certItem.Sign))
            {
                var currentAlipayPublicKey = await _publicKeyManager.GetAlipayPublicKeyAsync(this, options, certItem.CertSN);
                var rsaCheckContent = AlipaySignature.RSACheckContent(certItem.SignSourceData, certItem.Sign, currentAlipayPublicKey, options.SignType);
                if (!rsaCheckContent)
                {
                    if (!string.IsNullOrEmpty(certItem.SignSourceData) && certItem.SignSourceData.Contains("\\/"))
                    {
                        var srouceData = certItem.SignSourceData.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, certItem.Sign, currentAlipayPublicKey, options.SignType);
                        if (!jsonCheck)
                        {
                            throw new AlipayException("cert check fail: check Cert and Data Fail JSON also");
                        }
                    }
                    else
                    {
                        throw new AlipayException("cert check fail: check Cert and Data Fail!");
                    }
                }
            }
        }

        #endregion

        #region Common Method

        private static ResponseParseItem ParseRespItem<T>(IAlipayRequest<T> request, string respBody, IAlipayParser<T> parser, string encryptKey, string encryptType) where T : AlipayResponse
        {
            string realContent;
            if (request.GetNeedEncrypt())
            {
                realContent = parser.EncryptSourceData(request, respBody, encryptType, encryptKey);
            }
            else
            {
                realContent = respBody;
            }

            return new ResponseParseItem
            {
                RealContent = realContent,
                RespContent = respBody
            };
        }

        private static string BuildHtmlRequest(IDictionary<string, string> dictionary, string serverUrl, string strMethod)
        {
            var sb = new StringBuilder();
            sb.Append($"<form id='submit' name='submit' action='{serverUrl}?charset=utf-8' method='{strMethod}' style='display:none;'>");
            foreach (var iter in dictionary)
            {
                sb.Append($"<input name='{iter.Key}' value='{iter.Value}'/>");
            }
            sb.Append("<input type='submit' style='display:none;'></form>");
            sb.Append("<script>document.forms['submit'].submit();</script>");
            return sb.ToString();
        }

        private static AlipayDictionary BuildRequestParams<T>(IAlipayRequest<T> request, string accessToken, string appAuthToken, AlipayOptions options) where T : AlipayResponse
        {
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            // 添加协议级请求参数
            var result = new AlipayDictionary(request.GetParameters())
            {
                { AlipayConstants.METHOD, request.GetApiName() },
                { AlipayConstants.VERSION, apiVersion },
                { AlipayConstants.APP_ID, options.AppId },
                { AlipayConstants.FORMAT, options.Format },
                { AlipayConstants.TIMESTAMP, DateTime.Now },
                { AlipayConstants.ACCESS_TOKEN, accessToken },
                { AlipayConstants.SIGN_TYPE, options.SignType },
                { AlipayConstants.TERMINAL_TYPE, request.GetTerminalType() },
                { AlipayConstants.TERMINAL_INFO, request.GetTerminalInfo() },
                { AlipayConstants.PROD_CODE, request.GetProdCode() },
                { AlipayConstants.NOTIFY_URL, request.GetNotifyUrl() },
                { AlipayConstants.CHARSET, options.Charset },
                { AlipayConstants.RETURN_URL, request.GetReturnUrl() },
                { AlipayConstants.APP_AUTH_TOKEN, appAuthToken },
                { AlipayConstants.ALIPAY_ROOT_CERT_SN, options.AlipayRootCertSN },
                { AlipayConstants.APP_CERT_SN, options.AppCertSN }
            };

            // 序列化BizModel
            result = SerializeBizModel(result, request);

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(result[AlipayConstants.BIZ_CONTENT]))
                {
                    throw new AlipayException("api request Fail ! The reason: encrypt request is not supported!");
                }

                if (string.IsNullOrEmpty(options.EncryptKey) || string.IsNullOrEmpty(options.EncryptType))
                {
                    throw new AlipayException("encryptType or encryptKey must not null!");
                }

                if (!"AES".Equals(options.EncryptType))
                {
                    throw new AlipayException("api only support Aes!");
                }

                var encryptContent = AlipaySignature.AESEncrypt(result[AlipayConstants.BIZ_CONTENT], options.EncryptKey);
                result.Remove(AlipayConstants.BIZ_CONTENT);
                result.Add(AlipayConstants.BIZ_CONTENT, encryptContent);
                result.Add(AlipayConstants.ENCRYPT_TYPE, options.EncryptType);
            }

            return result;
        }

        #endregion

        #region SDK Execute

        public async Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options) where T : AlipayResponse
        {
            return await SdkExecuteAsync(request, options, null);
        }

        public Task<T> SdkExecuteAsync<T>(IAlipayRequest<T> request, AlipayOptions options, string appAuthToken) where T : AlipayResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.AppId))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppId)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.SignType))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.SignType)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.AppPrivateKey))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.AppPrivateKey)} is Empty!");
            }

            if (string.IsNullOrEmpty(options.ServerUrl))
            {
                throw new AlipayException($"options.{nameof(AlipayOptions.ServerUrl)} is Empty!");
            }

            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, appAuthToken, options);

            // 字典排序
            var sortedParams = new SortedDictionary<string, string>(requestParams, StringComparer.Ordinal);
            var sortedDic = new AlipayDictionary(sortedParams);

            // 参数签名
            var signContent = AlipaySignature.GetSignContent(sortedDic);
            var signResult = AlipaySignature.RSASignContent(signContent, options.AppPrivateKey, options.SignType);

            // 添加签名结果参数
            sortedDic.Add(AlipayConstants.SIGN, signResult);

            // 参数拼接
            var signedResult = AlipayUtility.BuildQuery(sortedDic);

            // 构造结果
            var rsp = Activator.CreateInstance<T>();
            rsp.Body = signedResult;
            return Task.FromResult(rsp);
        }

        #endregion

        #region Model Serialize

        private static AlipayDictionary SerializeBizModel<T>(AlipayDictionary requestParams, IAlipayRequest<T> request) where T : AlipayResponse
        {
            var result = requestParams;
            var isBizContentEmpty = !requestParams.ContainsKey(AlipayConstants.BIZ_CONTENT) || string.IsNullOrEmpty(requestParams[AlipayConstants.BIZ_CONTENT]);
            var bizModel = request.GetBizModel();
            if (isBizContentEmpty && bizModel != null)
            {
                var content = JsonSerializer.Serialize(bizModel, bizModel.GetType(), JsonParser.JsonSerializerOptions);
                result.Add(AlipayConstants.BIZ_CONTENT, content);
            }

            return result;
        }

        #endregion
    }
}
