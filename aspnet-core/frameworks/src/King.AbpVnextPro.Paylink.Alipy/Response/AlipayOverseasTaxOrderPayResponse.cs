﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTaxOrderPayResponse.
    /// </summary>
    public class AlipayOverseasTaxOrderPayResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝的退税流水号
        /// </summary>
        [JsonPropertyName("tax_no")]
        public string TaxNo { get; set; }
    }
}
