﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MorphoSource Data Structure.
    /// </summary>
    public class MorphoSource : AlipayObject
    {
        /// <summary>
        /// 基于源码的发布流程的源码信息
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 调用方侧对应应用唯一标识
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
