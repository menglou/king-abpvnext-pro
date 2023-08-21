using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiTradeKbpaymentPayorderSyncResponse.
    /// </summary>
    public class KoubeiTradeKbpaymentPayorderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
