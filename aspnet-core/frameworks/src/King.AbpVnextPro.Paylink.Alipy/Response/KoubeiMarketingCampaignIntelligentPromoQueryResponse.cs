using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询返回的营销活动模型
        /// </summary>
        [JsonPropertyName("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
