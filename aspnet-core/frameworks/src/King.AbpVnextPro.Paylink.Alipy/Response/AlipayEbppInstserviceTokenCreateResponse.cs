﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInstserviceTokenCreateResponse.
    /// </summary>
    public class AlipayEbppInstserviceTokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预签约令牌
        /// </summary>
        [JsonPropertyName("sign_token")]
        public string SignToken { get; set; }
    }
}
