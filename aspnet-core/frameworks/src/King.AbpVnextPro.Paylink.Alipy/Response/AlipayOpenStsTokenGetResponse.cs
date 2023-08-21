﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenStsTokenGetResponse.
    /// </summary>
    public class AlipayOpenStsTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 安全令牌失效时间（1970年1月1日00:00:00开始算起的毫秒数）
        /// </summary>
        [JsonPropertyName("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 安全令牌
        /// </summary>
        [JsonPropertyName("security_token")]
        public string SecurityToken { get; set; }
    }
}
