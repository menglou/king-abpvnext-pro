﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.gotone.ackcode.verify
    /// </summary>
    public class AlipayGotoneAckcodeVerifyRequest : IAlipayRequest<AlipayGotoneAckcodeVerifyResponse>
    {
        /// <summary>
        /// 校验码
        /// </summary>
        public string AckCode { get; set; }

        /// <summary>
        /// 区分相同的手机号、业务类型，但不同业务场景的手机校验码等情况校验。比如使用order_n
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 手机校验码业务类型，为空默认DEFAULT_TYPE
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 接收校验码短信手机号
        /// </summary>
        public string Mobile { get; set; }

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
            return "alipay.gotone.ackcode.verify";
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
                { "ack_code", AckCode },
                { "biz_no", BizNo },
                { "biz_type", BizType },
                { "mobile", Mobile }
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
