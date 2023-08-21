﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceQueryModel : AlipayObject
    {
        /// <summary>
        /// 按类型查找， 空默认查询所有
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
