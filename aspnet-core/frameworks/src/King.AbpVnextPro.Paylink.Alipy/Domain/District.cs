﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// District Data Structure.
    /// </summary>
    public class District : AlipayObject
    {
        /// <summary>
        /// 行政地区编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行政地区名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
