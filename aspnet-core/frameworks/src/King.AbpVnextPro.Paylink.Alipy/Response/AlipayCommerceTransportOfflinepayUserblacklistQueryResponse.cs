﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayUserblacklistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 黑名单用户ID
        /// </summary>
        [JsonPropertyName("black_list")]
        public List<string> BlackList { get; set; }
    }
}
