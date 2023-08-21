﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingDataIntelligentEffectQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataIntelligentEffectQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 咨询后返回的模型，包含活动本身的模型以及效果模型
        /// </summary>
        [JsonPropertyName("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
