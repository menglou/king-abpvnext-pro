using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动详情
        /// </summary>
        [JsonPropertyName("camp_detail")]
        public CampDetail CampDetail { get; set; }
    }
}
