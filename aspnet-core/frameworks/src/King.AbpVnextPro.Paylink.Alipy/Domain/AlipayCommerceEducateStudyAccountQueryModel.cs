﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudyAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateStudyAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 学校内标
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
