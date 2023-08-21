using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportOilproductInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOilproductInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 油站列表
        /// </summary>
        [JsonPropertyName("oil_station_models")]
        public OilStationDetails OilStationModels { get; set; }
    }
}
