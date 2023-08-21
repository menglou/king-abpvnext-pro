﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertCommissionClauseQuotaResponse Data Structure.
    /// </summary>
    public class KbAdvertCommissionClauseQuotaResponse : AlipayObject
    {
        /// <summary>
        /// 分佣定额(精度2位的非负小数)
        /// </summary>
        [JsonPropertyName("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
