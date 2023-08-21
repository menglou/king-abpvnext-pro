﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoEprintTaskSubmitResponse.
    /// </summary>
    public class AlipayEcoEprintTaskSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 云平台订单ID
        /// </summary>
        [JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; }
    }
}
