using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingMallMemberModifyResponse.
    /// </summary>
    public class KoubeiMarketingMallMemberModifyResponse : AlipayResponse
    {
        /// <summary>
        /// true：成功，false：失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
