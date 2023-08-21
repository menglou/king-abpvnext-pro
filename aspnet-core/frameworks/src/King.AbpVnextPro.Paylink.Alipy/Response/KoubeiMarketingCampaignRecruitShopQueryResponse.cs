﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRecruitShopQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRecruitShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 招商活动id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [JsonPropertyName("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 招商门店确认详情
        /// </summary>
        [JsonPropertyName("shop_info")]
        public List<RecruitShopInfo> ShopInfo { get; set; }
    }
}
