﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// Keyword Data Structure.
    /// </summary>
    public class Keyword : AlipayObject
    {
        /// <summary>
        /// 当前文字颜色
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// 模板中占位符的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
