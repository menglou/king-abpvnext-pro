﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询返回的营销活动列表信息
        /// </summary>
        [JsonPropertyName("intelligent_promos")]
        public List<IntelligentPromo> IntelligentPromos { get; set; }

        /// <summary>
        /// 查询后返回的分页信息
        /// </summary>
        [JsonPropertyName("page_result")]
        public PromoPageResult PageResult { get; set; }
    }
}
