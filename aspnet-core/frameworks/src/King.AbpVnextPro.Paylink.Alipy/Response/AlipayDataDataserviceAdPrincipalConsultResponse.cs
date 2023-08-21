using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalConsultResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 签约平台地址
        /// </summary>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }
    }
}
