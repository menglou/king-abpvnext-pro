using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignBenefitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// benefitQueryInfo: 权益查询接口返回的具体权益信息
        /// </summary>
        [JsonPropertyName("benefit_query_info")]
        public BenefitQueryInfo BenefitQueryInfo { get; set; }
    }
}
