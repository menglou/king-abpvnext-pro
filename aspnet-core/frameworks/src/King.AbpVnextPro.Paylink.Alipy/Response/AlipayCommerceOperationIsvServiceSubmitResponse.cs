using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvServiceSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// id （后续消息标识对应服务）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
