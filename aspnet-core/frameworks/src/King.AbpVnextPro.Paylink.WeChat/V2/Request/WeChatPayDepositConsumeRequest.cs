﻿using System.Collections.Generic;
using King.AbpVnextPro.Paylink.WeChat.V2.Response;

namespace King.AbpVnextPro.Paylink.WeChat.V2.Request
{
    /// <summary>
    /// 酒店押金 - 消费押金 (服务商)
    /// </summary>
    public class WeChatPayDepositConsumeRequest : IWeChatPayCertRequest<WeChatPayDepositConsumeResponse>
    {
        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 押金总金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        public int ConsumeFee { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string FeeType { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/deposit/consume";
        private WeChatPaySignType signType = WeChatPaySignType.HMAC_SHA256;

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
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo },
                { "total_fee", TotalFee },
                { "consume_fee", ConsumeFee },
                { "fee_type", FeeType },
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
                WeChatPaySignType.HMAC_SHA256 => signType,
                _ => throw new WeChatPayException("api only support HMAC_SHA256!"),
            };
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign_type, signType);
            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
