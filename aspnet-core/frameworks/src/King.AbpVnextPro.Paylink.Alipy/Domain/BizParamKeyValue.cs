﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BizParamKeyValue Data Structure.
    /// </summary>
    public class BizParamKeyValue : AlipayObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
