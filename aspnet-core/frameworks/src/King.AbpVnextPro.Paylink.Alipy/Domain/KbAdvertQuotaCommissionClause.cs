﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    public class KbAdvertQuotaCommissionClause : AlipayObject
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        [JsonPropertyName("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
