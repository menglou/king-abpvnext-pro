﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionauthtokenCreateResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionauthtokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 通知authToken
        /// </summary>
        [JsonPropertyName("authentication_token")]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// 响应报文头部
        /// </summary>
        [JsonPropertyName("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }

        /// <summary>
        /// 是否允许通知状态转移
        /// </summary>
        [JsonPropertyName("supports_settlement")]
        public bool SupportsSettlement { get; set; }
    }
}
