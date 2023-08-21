using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 运营活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
