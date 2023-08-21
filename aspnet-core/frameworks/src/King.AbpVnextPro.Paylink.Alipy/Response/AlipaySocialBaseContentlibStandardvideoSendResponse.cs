﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardvideoSendResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardvideoSendResponse : AlipayResponse
    {
        /// <summary>
        /// result_msg为请求openAPI接口后返回的结果message
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
