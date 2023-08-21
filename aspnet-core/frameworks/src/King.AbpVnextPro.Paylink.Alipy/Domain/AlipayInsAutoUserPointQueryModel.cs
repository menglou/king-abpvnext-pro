﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoUserPointQueryModel Data Structure.
    /// </summary>
    public class AlipayInsAutoUserPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 车险活动类型编码。  攒油活动：SAVE_OIL
        /// </summary>
        [JsonPropertyName("auto_campaign_type")]
        public string AutoCampaignType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
