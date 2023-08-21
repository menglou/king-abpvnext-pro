﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// TransactionAmountDTO Data Structure.
    /// </summary>
    public class TransactionAmountDTO : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
