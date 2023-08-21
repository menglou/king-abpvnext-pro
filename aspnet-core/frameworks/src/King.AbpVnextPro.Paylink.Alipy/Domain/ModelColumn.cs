﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ModelColumn Data Structure.
    /// </summary>
    public class ModelColumn : AlipayObject
    {
        /// <summary>
        /// 列别名
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 列值
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
