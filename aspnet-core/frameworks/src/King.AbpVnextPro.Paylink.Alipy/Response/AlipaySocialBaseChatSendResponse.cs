using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseChatSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatSendResponse : AlipayResponse
    {
        /// <summary>
        /// msg_index:msgid+sessionId
        /// </summary>
        [JsonPropertyName("msg_index")]
        public string MsgIndex { get; set; }
    }
}
