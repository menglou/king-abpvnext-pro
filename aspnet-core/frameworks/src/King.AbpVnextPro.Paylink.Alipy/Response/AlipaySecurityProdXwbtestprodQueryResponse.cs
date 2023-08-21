﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdXwbtestprodQueryResponse.
    /// </summary>
    public class AlipaySecurityProdXwbtestprodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 11000
        /// </summary>
        [JsonPropertyName("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// xxxx
        /// </summary>
        [JsonPropertyName("out_b")]
        public long OutB { get; set; }
    }
}
