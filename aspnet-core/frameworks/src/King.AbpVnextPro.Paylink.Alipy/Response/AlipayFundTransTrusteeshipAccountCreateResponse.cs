﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundTransTrusteeshipAccountCreateResponse.
    /// </summary>
    public class AlipayFundTransTrusteeshipAccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 开设的支付宝账号user_id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [JsonPropertyName("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
