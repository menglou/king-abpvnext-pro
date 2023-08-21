﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;
using King.AbpVnextPro.Paylink.Alipy.Utility;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.offline.material.image.upload
    /// </summary>
    public class AlipayOfflineMaterialImageUploadRequest : IAlipayUploadRequest<AlipayOfflineMaterialImageUploadResponse>
    {
        /// <summary>
        /// 图片/视频二进制内容，图片/视频大小不能超过5M
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 图片/视频名称
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// 用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）
        /// </summary>
        public string ImagePid { get; set; }

        /// <summary>
        /// 图片/视频格式
        /// </summary>
        public string ImageType { get; set; }

        #region IAlipayRequest Members

        private bool needEncrypt = false;
        private string apiVersion = "1.0";
        private string terminalType;
        private string terminalInfo;
        private string prodCode;
        private string notifyUrl;
        private string returnUrl;
        private AlipayObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

        public void SetNeedEncrypt(bool needEncrypt)
        {
            this.needEncrypt = needEncrypt;
        }

        public bool GetNeedEncrypt()
        {
            return needEncrypt;
        }

        public void SetNotifyUrl(string notifyUrl)
        {
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl()
        {
            return notifyUrl;
        }

        public void SetReturnUrl(string returnUrl)
        {
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl()
        {
            return returnUrl;
        }

        public void SetTerminalType(string terminalType)
        {
            this.terminalType = terminalType;
        }

        public string GetTerminalType()
        {
            return terminalType;
        }

        public void SetTerminalInfo(string terminalInfo)
        {
            this.terminalInfo = terminalInfo;
        }

        public string GetTerminalInfo()
        {
            return terminalInfo;
        }

        public void SetProdCode(string prodCode)
        {
            this.prodCode = prodCode;
        }

        public string GetProdCode()
        {
            return prodCode;
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.offline.material.image.upload";
        }

        public void PutOtherTextParam(string key, string value)
        {
            if (udfParams == null)
            {
                udfParams = new Dictionary<string, string>();
            }
            udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new AlipayDictionary
            {
                { "image_name", ImageName },
                { "image_pid", ImagePid },
                { "image_type", ImageType }
            };
            if (udfParams != null)
            {
                parameters.AddAll(udfParams);
            }
            return parameters;
        }

        public AlipayObject GetBizModel()
        {
            return bizModel;
        }

        public void SetBizModel(AlipayObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAlipayUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            var parameters = new Dictionary<string, FileItem>
            {
                { "image_content", ImageContent }
            };
            return parameters;
        }

        #endregion
    }
}
