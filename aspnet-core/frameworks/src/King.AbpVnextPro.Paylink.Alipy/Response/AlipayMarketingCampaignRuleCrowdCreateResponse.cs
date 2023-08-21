using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 圈人规则id
        /// </summary>
        [JsonPropertyName("ruleid")]
        public string Ruleid { get; set; }
    }
}
