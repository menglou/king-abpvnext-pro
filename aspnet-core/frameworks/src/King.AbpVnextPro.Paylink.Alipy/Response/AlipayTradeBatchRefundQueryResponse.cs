﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundQueryResponse.
    /// </summary>
    public class AlipayTradeBatchRefundQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 退款明细信息
        /// </summary>
        [JsonPropertyName("result_details")]
        public List<BatchRefundDetailResult> ResultDetails { get; set; }
    }
}
