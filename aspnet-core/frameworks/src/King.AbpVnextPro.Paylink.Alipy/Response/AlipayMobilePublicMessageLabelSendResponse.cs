using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageLabelSendResponse.
    /// </summary>
    public class AlipayMobilePublicMessageLabelSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("msg_id")]
        public string MsgId { get; set; }
    }
}
