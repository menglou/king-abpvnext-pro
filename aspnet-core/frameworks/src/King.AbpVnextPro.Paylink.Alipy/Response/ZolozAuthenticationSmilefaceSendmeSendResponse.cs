using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZolozAuthenticationSmilefaceSendmeSendResponse.
    /// </summary>
    public class ZolozAuthenticationSmilefaceSendmeSendResponse : AlipayResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
