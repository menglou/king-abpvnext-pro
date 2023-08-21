﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthTokenAppQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [JsonPropertyName("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
