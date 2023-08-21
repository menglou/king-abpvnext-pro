﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataBillBalancehisQueryResponse.
    /// </summary>
    public class AlipayDataBillBalancehisQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 期初余额
        /// </summary>
        [JsonPropertyName("beginning_balance")]
        public string BeginningBalance { get; set; }

        /// <summary>
        /// 期末余额
        /// </summary>
        [JsonPropertyName("ending_balance")]
        public string EndingBalance { get; set; }
    }
}
