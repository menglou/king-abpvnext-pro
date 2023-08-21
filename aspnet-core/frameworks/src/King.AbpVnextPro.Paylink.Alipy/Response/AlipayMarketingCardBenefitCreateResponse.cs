using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitCreateResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
