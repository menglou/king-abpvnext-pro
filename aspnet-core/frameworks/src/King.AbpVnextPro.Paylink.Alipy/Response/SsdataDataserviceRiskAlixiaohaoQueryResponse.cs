﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAlixiaohaoQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否阿里小号
        /// </summary>
        [JsonPropertyName("is_alixiaohao")]
        public bool IsAlixiaohao { get; set; }
    }
}
