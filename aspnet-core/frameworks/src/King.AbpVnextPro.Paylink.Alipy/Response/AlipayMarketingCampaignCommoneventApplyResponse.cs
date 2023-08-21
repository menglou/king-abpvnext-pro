﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCommoneventApplyResponse.
    /// </summary>
    public class AlipayMarketingCampaignCommoneventApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 与event关联的返回结果
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
