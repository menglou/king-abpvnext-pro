using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对象
        /// </summary>
        [JsonPropertyName("data")]
        public RechargeOrderTuitionDTO Data { get; set; }
    }
}
