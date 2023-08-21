using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerBizruleMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerBizruleMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 匹配详情
        /// </summary>
        [JsonPropertyName("match_result")]
        public string MatchResult { get; set; }
    }
}
