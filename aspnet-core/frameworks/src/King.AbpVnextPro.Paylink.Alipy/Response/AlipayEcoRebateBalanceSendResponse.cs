﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoRebateBalanceSendResponse.
    /// </summary>
    public class AlipayEcoRebateBalanceSendResponse : AlipayResponse
    {
        /// <summary>
        /// 给用户发放集分宝的数量
        /// </summary>
        [JsonPropertyName("jfb_amount")]
        public string JfbAmount { get; set; }
    }
}
