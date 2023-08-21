﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部id
        /// </summary>
        [JsonPropertyName("external_unique_id")]
        public string ExternalUniqueId { get; set; }
    }
}
