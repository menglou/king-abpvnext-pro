using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniBizdataTemplatemessageUploadResponse.
    /// </summary>
    public class AlipayOpenMiniBizdataTemplatemessageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 成功：true 失败：false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
