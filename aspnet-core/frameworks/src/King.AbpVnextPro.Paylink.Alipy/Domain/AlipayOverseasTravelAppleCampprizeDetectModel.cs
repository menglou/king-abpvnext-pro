﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasTravelAppleCampprizeDetectModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelAppleCampprizeDetectModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
