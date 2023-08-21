﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectModel Data Structure.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserlogoutEffectModel : AlipayObject
    {
        /// <summary>
        /// 登录的sessionId
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }
    }
}
