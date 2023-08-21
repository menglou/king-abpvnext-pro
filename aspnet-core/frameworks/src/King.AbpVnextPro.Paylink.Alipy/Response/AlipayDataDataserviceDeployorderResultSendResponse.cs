using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderResultSendResponse : AlipayResponse
    {
        /// <summary>
        /// 处理是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
