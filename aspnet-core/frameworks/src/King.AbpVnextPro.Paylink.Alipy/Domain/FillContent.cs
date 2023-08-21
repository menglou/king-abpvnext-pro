﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// FillContent Data Structure.
    /// </summary>
    public class FillContent : AlipayObject
    {
        /// <summary>
        /// 模板组件自定义key
        /// </summary>
        [JsonPropertyName("struct_key")]
        public string StructKey { get; set; }

        /// <summary>
        /// 模板值,该值长度取决于配置模板时该字段的限制
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
