﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ServiceAttributeSimpleVO Data Structure.
    /// </summary>
    public class ServiceAttributeSimpleVO : AlipayObject
    {
        /// <summary>
        /// 服务属性key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// abcd
        /// </summary>
        [JsonPropertyName("value")]
        public List<string> Value { get; set; }
    }
}
