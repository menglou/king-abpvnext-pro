﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.WeChat.V2.Response;

namespace King.AbpVnextPro.Paylink.WeChat.V2.Request
{
    /// <summary>
    /// 查询代金券批次 (普通商户)
    /// </summary>
    public class WeChatPayQueryCouponStockRequest : IWeChatPayRequest<WeChatPayQueryCouponStockResponse>
    {
        /// <summary>
        /// 代金券批次id
        /// </summary>
        public string CouponStockId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        public string Type { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/mmpaymkttransfers/query_coupon_stock";
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
                { "coupon_stock_id", CouponStockId },
                { "op_user_id", OpUserId },
                { "device_info", DeviceInfo },
                { "version", Version },
                { "type", Type }
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
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
