using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("market_info")]
        public MarketInfo MarketInfo { get; set; }
    }
}
