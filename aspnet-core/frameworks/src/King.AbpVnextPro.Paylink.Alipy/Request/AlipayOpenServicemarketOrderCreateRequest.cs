﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.Alipy.Response;
using King.AbpVnextPro.Paylink.Alipy.Utility;

namespace King.AbpVnextPro.Paylink.Alipy.Request
{
    /// <summary>
    /// alipay.open.servicemarket.order.create
    /// </summary>
    public class AlipayOpenServicemarketOrderCreateRequest : IAlipayUploadRequest<AlipayOpenServicemarketOrderCreateResponse>
    {
        /// <summary>
        /// 11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.alipay.com/isv/10325
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序官方示例Demo，展示已支持的接口能力及组件。
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 来源的业务方，需要申请
        /// </summary>
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 订购的服务商品ID所在的市场编码。新接入场景必须传递，具体值请联系产品分配。
        /// </summary>
        public string MarketCode { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        public string MerchantPid { get; set; }

        /// <summary>
        /// 一二方支持传入appId
        /// </summary>
        public string MiniAppId { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        public string ServicePhone { get; set; }

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
            return "alipay.open.servicemarket.order.create";
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
                { "app_category_ids", AppCategoryIds },
                { "app_desc", AppDesc },
                { "app_english_name", AppEnglishName },
                { "app_name", AppName },
                { "app_origin", AppOrigin },
                { "app_slogan", AppSlogan },
                { "market_code", MarketCode },
                { "merchandise_id", MerchandiseId },
                { "merchant_pid", MerchantPid },
                { "mini_app_id", MiniAppId },
                { "mini_category_ids", MiniCategoryIds },
                { "out_biz_no", OutBizNo },
                { "service_email", ServiceEmail },
                { "service_phone", ServicePhone }
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
                { "app_logo", AppLogo }
            };
            return parameters;
        }

        #endregion
    }
}
