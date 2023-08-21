﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.WeChat.V2.Response;

namespace King.AbpVnextPro.Paylink.WeChat.V2.Request
{
    /// <summary>
    /// 企业付款到零钱 (普通商户)
    /// </summary>
    public class WeChatPayPromotionTransfersRequest : IWeChatPayCertRequest<WeChatPayPromotionTransfersResponse>
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string PartnerTradeNo { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 校验用户姓名选项
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// 收款用户姓名
        /// </summary>
        public string ReUserName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 企业付款备注
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string SpBillCreateIp { get; set; }

        #region IWeChatPayCertRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/promotion/transfers";
        private WeChatPaySignType signType = WeChatPaySignType.MD5;

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "device_info", DeviceInfo },
                { "partner_trade_no", PartnerTradeNo },
                { "openid", OpenId },
                { "check_name", CheckName },
                { "re_user_name", ReUserName },
                { "amount", Amount },
                { "desc", Desc },
                { "spbill_create_ip", SpBillCreateIp }
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return signType;
        }

        public void SetSignType(WeChatPaySignType signType)
        {
            this.signType = signType switch
            {
                WeChatPaySignType.MD5 => signType,
                _ => throw new WeChatPayException("api only support MD5!"),
            };
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.mch_appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mchid, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        public bool GetNeedCheckSign()
        {
            return false;
        }

        #endregion
    }
}
