﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbadvertChannelTypeResponse Data Structure.
    /// </summary>
    public class KbadvertChannelTypeResponse : AlipayObject
    {
        /// <summary>
        /// 渠道描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 排序，暂时无用
        /// </summary>
        [JsonPropertyName("order")]
        public string Order { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
