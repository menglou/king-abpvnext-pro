﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceKidsAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceKidsAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 登陆名
        /// </summary>
        [JsonPropertyName("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
