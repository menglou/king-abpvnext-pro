﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// QuoteInfo Data Structure.
    /// </summary>
    public class QuoteInfo : AlipayObject
    {
        /// <summary>
        /// 238810000000049704774
        /// </summary>
        [JsonPropertyName("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
