﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserCharityForestQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCharityForestQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
