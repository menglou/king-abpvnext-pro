﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsDataAutoCoefficientSyncResponse.
    /// </summary>
    public class AlipayInsDataAutoCoefficientSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 用户唯一请求id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
