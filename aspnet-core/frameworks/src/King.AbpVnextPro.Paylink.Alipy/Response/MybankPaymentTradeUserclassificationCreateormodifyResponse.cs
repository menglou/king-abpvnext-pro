using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankPaymentTradeUserclassificationCreateormodifyResponse.
    /// </summary>
    public class MybankPaymentTradeUserclassificationCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 打标结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
