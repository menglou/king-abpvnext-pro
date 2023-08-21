﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantEnterstatusQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceMerchantEnterstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 工单状态，审核中：AUDITING，验收中：ACCEPTING，成功：SUCCESS，失败：FAIL
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
