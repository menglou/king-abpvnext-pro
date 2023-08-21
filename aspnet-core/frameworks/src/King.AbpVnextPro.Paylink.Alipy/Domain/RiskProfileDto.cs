﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// RiskProfileDto Data Structure.
    /// </summary>
    public class RiskProfileDto : AlipayObject
    {
        /// <summary>
        /// risk profile名称和入参对应
        /// </summary>
        [JsonPropertyName("risk_profile")]
        public string RiskProfile { get; set; }

        /// <summary>
        /// risk profile对应主体的分值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
