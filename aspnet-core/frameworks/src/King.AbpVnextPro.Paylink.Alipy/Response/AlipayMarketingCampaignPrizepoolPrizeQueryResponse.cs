using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 指定奖品id的详细配置
        /// </summary>
        [JsonPropertyName("prize_config")]
        public PrizeConfig PrizeConfig { get; set; }
    }
}
