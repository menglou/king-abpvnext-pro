using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [JsonPropertyName("lot_number")]
        public string LotNumber { get; set; }
    }
}
