﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsMarketingDiscountPreuseResponse.
    /// </summary>
    public class AlipayInsMarketingDiscountPreuseResponse : AlipayResponse
    {
        /// <summary>
        /// 预核销活动列表
        /// </summary>
        [JsonPropertyName("pre_use_campaigns")]
        public List<InsMktPreUseCampaignDTO> PreUseCampaigns { get; set; }

        /// <summary>
        /// 预核销权益列表
        /// </summary>
        [JsonPropertyName("pre_use_coupons")]
        public List<InsMktPreUseCouponDTO> PreUseCoupons { get; set; }
    }
}
