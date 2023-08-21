﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoRenthouseRenterZhimaQueryResponse.
    /// </summary>
    public class AlipayEcoRenthouseRenterZhimaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 状态值（等级值、未授权、未知）
        /// </summary>
        [JsonPropertyName("status_value")]
        public string StatusValue { get; set; }
    }
}
