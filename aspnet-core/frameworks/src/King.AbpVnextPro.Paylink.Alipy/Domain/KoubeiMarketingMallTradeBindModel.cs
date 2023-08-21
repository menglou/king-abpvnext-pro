﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindModel Data Structure.
    /// </summary>
    public class KoubeiMarketingMallTradeBindModel : AlipayObject
    {
        /// <summary>
        /// 用户的授权动作：auth授权，unAuth取消授权
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
