﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ActionProperty Data Structure.
    /// </summary>
    public class ActionProperty : AlipayObject
    {
        /// <summary>
        /// 属性C端渲染key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 交互动作属性元素类型，IMG-图片；TEXT-普通文本
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 属性图片URL；属性文本值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
