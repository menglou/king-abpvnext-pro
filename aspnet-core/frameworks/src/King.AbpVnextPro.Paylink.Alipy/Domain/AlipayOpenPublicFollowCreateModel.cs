﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicFollowCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicFollowCreateModel : AlipayObject
    {
        /// <summary>
        /// 来源，目前只有"tmall"
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
