﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountExrateRatequeryModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateRatequeryModel : AlipayObject
    {
        /// <summary>
        /// 需要查询汇率的货币对，如果为空则返回当前支持的所有货币对的汇率
        /// </summary>
        [JsonPropertyName("currency_pair")]
        public string CurrencyPair { get; set; }
    }
}
