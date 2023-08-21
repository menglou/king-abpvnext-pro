﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbadvertSmartPromoRequest Data Structure.
    /// </summary>
    public class KbadvertSmartPromoRequest : AlipayObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
