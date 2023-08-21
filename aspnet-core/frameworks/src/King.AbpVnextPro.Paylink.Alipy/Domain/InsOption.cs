﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsOption Data Structure.
    /// </summary>
    public class InsOption : AlipayObject
    {
        /// <summary>
        /// 保额key
        /// </summary>
        [JsonPropertyName("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 保额value
        /// </summary>
        [JsonPropertyName("coverage_text")]
        public string CoverageText { get; set; }
    }
}
