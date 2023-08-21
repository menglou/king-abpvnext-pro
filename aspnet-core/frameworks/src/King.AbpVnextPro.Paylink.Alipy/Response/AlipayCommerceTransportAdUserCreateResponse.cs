﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdUserCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 广告系统用户ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public string AdUserId { get; set; }
    }
}
