using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeSingletripdurationQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeSingletripdurationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 查询结果集合
        /// </summary>
        [JsonPropertyName("result")]
        public List<SingleTripDurationQueryOpenapiResult> Result { get; set; }
    }
}
