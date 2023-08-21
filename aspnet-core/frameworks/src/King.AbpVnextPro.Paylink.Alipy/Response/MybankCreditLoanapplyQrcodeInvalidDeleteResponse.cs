﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteResponse.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeInvalidDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// true:失效成功 false:失效失败
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }
    }
}
