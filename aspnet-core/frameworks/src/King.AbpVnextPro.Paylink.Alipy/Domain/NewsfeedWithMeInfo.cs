﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// NewsfeedWithMeInfo Data Structure.
    /// </summary>
    public class NewsfeedWithMeInfo : AlipayObject
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
