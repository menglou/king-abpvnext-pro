using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCountResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCountResponse : AlipayResponse
    {
        /// <summary>
        /// 统计规则或标签所圈定的人群数目
        /// </summary>
        [JsonPropertyName("crowdcount")]
        public string Crowdcount { get; set; }
    }
}
