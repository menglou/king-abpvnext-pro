﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;
using King.AbpVnextPro.Paylink.Alipy.Utility;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.ebpp.merchant.meterial.upload
    /// </summary>
    public class AlipayEbppMerchantMeterialUploadRequest : IAlipayUploadRequest<AlipayEbppMerchantMeterialUploadResponse>
    {
        /// <summary>
        /// 文件二进制
        /// </summary>
        public FileItem Content { get; set; }

        /// <summary>
        /// 实体创建时对应的code，如小区或物业的shortName。当entity_type=RELATIONSHIP时，entity_code=关系id
        /// </summary>
        public string EntityCode { get; set; }

        /// <summary>
        /// 实体类型： COMMUNITY_COMPANY("COMMUNITY_COMPANY", "物业"), OMMUNITY_INFO("COMMUNITY_INFO", "小区"), COMMUNITY_ISV("COMMUNITY_ISV", "ISV"), RELATIONSHIP("RELATIONSHIP", "物业小区绑定关系"), EXTERNAL_BILL_INFO("EXTERNAL_BILL_INFO", "账单"),;
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        public string FileDesc { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

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
            return "alipay.ebpp.merchant.meterial.upload";
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
                { "entity_code", EntityCode },
                { "entity_type", EntityType },
                { "file_desc", FileDesc },
                { "file_name", FileName },
                { "memo", Memo }
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
                { "content", Content }
            };
            return parameters;
        }

        #endregion
    }
}
