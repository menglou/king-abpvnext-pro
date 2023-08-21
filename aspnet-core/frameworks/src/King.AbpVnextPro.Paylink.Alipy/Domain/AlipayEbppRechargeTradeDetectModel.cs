﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppRechargeTradeDetectModel Data Structure.
    /// </summary>
    public class AlipayEbppRechargeTradeDetectModel : AlipayObject
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
