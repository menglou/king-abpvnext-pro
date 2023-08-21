using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoCreateResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
