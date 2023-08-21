﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiContentContentinfoModifyResponse.
    /// </summary>
    public class KoubeiContentContentinfoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 全链路Id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
