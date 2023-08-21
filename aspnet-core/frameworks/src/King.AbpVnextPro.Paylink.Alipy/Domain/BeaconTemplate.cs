﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BeaconTemplate Data Structure.
    /// </summary>
    public class BeaconTemplate : AlipayObject
    {
        /// <summary>
        /// 模板参数信息
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("templateid")]
        public string Templateid { get; set; }
    }
}
