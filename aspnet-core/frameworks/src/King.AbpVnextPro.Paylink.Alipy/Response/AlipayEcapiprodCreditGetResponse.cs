using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcapiprodCreditGetResponse.
    /// </summary>
    public class AlipayEcapiprodCreditGetResponse : AlipayResponse
    {
        /// <summary>
        /// 授信结果
        /// </summary>
        [JsonPropertyName("credit_result")]
        public CreditResult CreditResult { get; set; }

        /// <summary>
        /// 为了保持幂等性，返回唯一请求号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
