﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainArUnsignResponse.
    /// </summary>
    public class MybankCreditSupplychainArUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 解约结果：true/false
        /// </summary>
        [JsonPropertyName("invalid_result")]
        public bool InvalidResult { get; set; }
    }
}
