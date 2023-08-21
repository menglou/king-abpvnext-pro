using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankPaymentTradeDistrictQueryResponse.
    /// </summary>
    public class MybankPaymentTradeDistrictQueryResponse : AlipayResponse
    {
        /// <summary>
        /// District列表
        /// </summary>
        [JsonPropertyName("district_details")]
        public List<District> DistrictDetails { get; set; }
    }
}
