using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicContentPublishResponse.
    /// </summary>
    public class AlipayOpenPublicContentPublishResponse : AlipayResponse
    {
        /// <summary>
        /// message_id 用于描述生成的消息id
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
    }
}
