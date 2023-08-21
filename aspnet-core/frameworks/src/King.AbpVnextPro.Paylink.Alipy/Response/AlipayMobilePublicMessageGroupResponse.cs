using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageGroupResponse.
    /// </summary>
    public class AlipayMobilePublicMessageGroupResponse : AlipayResponse
    {
        /// <summary>
        /// code
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
