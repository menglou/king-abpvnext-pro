﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放平台生成的创意ID
        /// </summary>
        [JsonPropertyName("creative_id")]
        public long CreativeId { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放创意对应的外部资源ID
        /// </summary>
        [JsonPropertyName("creative_outer_id")]
        public string CreativeOuterId { get; set; }
    }
}
