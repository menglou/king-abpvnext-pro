using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankPaymentTradeQrcodeDeleteResponse.
    /// </summary>
    public class MybankPaymentTradeQrcodeDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// true:失效成功 false:失效失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
