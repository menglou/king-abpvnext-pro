using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝poi查询结果
        /// </summary>
        [JsonPropertyName("poi_query_result")]
        public PoiQueryResult PoiQueryResult { get; set; }
    }
}
