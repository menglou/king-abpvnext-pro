﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.ecard.edu.deposit.order.add
    /// </summary>
    public class AlipayEcardEduDepositOrderAddRequest : IAlipayRequest<AlipayEcardEduDepositOrderAddResponse>
    {
        /// <summary>
        /// 校园一卡通机构
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 校园一卡通帐户姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通号码
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 校园一卡通充值金额
        /// </summary>
        public string DepositAmount { get; set; }

        /// <summary>
        /// 成功充值通知手机号码
        /// </summary>
        public string MobileNo { get; set; }

        /// <summary>
        /// 公众平台ID
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// 是否分享手机号码
        /// </summary>
        public string ShareMobileNo { get; set; }

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
            return "alipay.ecard.edu.deposit.order.add";
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
                { "agent_code", AgentCode },
                { "agreement_id", AgreementId },
                { "alipay_user_id", AlipayUserId },
                { "card_name", CardName },
                { "card_no", CardNo },
                { "deposit_amount", DepositAmount },
                { "mobile_no", MobileNo },
                { "public_id", PublicId },
                { "share_mobile_no", ShareMobileNo }
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
