﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseBcgroupJoinedConsultResponse.
    /// </summary>
    public class AlipaySocialBaseBcgroupJoinedConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 入群状态。true为已经入群，false为未入群。
        /// </summary>
        [JsonPropertyName("joined")]
        public bool Joined { get; set; }
    }
}
