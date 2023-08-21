﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 单元id
        /// </summary>
        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 外部单元编号
        /// </summary>
        [JsonPropertyName("group_outer_id")]
        public string GroupOuterId { get; set; }
    }
}
