using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageTotalSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessageTotalSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
