using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityGetResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付能力返回结果信息
        /// </summary>
        [JsonPropertyName("payment_ability_query_response")]
        public PaymentAbilityQueryResponse PaymentAbilityQueryResponse { get; set; }
    }
}
