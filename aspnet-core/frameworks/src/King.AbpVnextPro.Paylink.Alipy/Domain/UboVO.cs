﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// UboVO Data Structure.
    /// </summary>
    public class UboVO : AlipayObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [JsonPropertyName("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 控股比例
        /// </summary>
        [JsonPropertyName("invest_rate")]
        public string InvestRate { get; set; }

        /// <summary>
        /// ubo名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
