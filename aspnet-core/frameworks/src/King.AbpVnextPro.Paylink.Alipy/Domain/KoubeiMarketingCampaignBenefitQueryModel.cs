using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitQueryModel : AlipayObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
