﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ProdResource Data Structure.
    /// </summary>
    public class ProdResource : AlipayObject
    {
        /// <summary>
        /// 资源项唯一标识
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 资源项名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源项类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资源向内容
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
