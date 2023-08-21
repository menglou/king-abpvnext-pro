using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动od
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
