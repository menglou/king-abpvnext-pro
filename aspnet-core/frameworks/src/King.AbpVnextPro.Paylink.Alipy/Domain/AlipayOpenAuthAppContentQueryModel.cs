﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppContentQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }
    }
}
