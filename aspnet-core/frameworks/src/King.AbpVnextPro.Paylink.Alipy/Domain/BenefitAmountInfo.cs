﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BenefitAmountInfo Data Structure.
    /// </summary>
    public class BenefitAmountInfo : AlipayObject
    {
        /// <summary>
        /// 可用面额
        /// </summary>
        [JsonPropertyName("benefit_available_amount")]
        public Amount BenefitAvailableAmount { get; set; }

        /// <summary>
        /// 总面额
        /// </summary>
        [JsonPropertyName("benefit_total_amount")]
        public Amount BenefitTotalAmount { get; set; }
    }
}
