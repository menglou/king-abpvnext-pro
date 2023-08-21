using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsMarketingCampaignQueryResponse.
    /// </summary>
    public class AlipayInsMarketingCampaignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保险营销活动信息
        /// </summary>
        [JsonPropertyName("mkt_campaign")]
        public InsMktCampaignDTO MktCampaign { get; set; }
    }
}
