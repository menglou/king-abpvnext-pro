﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// Dimension Data Structure.
    /// </summary>
    public class Dimension : AlipayObject
    {
        /// <summary>
        /// 维度类型
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 维度值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
