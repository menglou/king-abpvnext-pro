﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.mobile.public.message.custom.send
    /// </summary>
    public class AlipayMobilePublicMessageCustomSendRequest : IAlipayRequest<AlipayMobilePublicMessageCustomSendResponse>
    {
        /// <summary>
        /// 业务内容，其中包括消息类型msgType、消息体和消息接受人toUserId三大块，在toUserId这一层级新加eventType参数，该字段取值为follow:表示关注事件，click：表示菜单点击事件，enter_ppchat:代表进入事件。具体参见“表1-2 服务窗单发客服消息的biz_content参数说明”。  <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7386797.0.0.eZqycg&treeId=53&articleId=103448&docType=1">详情请见</a>
        /// </summary>
        public string BizContent { get; set; }

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

        public string GetApiName()
        {
            return "alipay.mobile.public.message.custom.send";
        }

        public void SetApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return apiVersion;
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
                { "biz_content", BizContent }
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
    }
}
