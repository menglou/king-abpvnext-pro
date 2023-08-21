using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDatabizCorePaymentAbilityUpdateResponse.
    /// </summary>
    public class AlipayDatabizCorePaymentAbilityUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付能力回传信息结果信息
        /// </summary>
        [JsonPropertyName("payment_ability_postback_response")]
        public PaymentAbilityPostbackResponse PaymentAbilityPostbackResponse { get; set; }
    }
}
