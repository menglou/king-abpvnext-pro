using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentPromoModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentPromoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改后返回的智能活动模型
        /// </summary>
        [JsonPropertyName("promo")]
        public IntelligentPromo Promo { get; set; }
    }
}
