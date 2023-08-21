using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniHmcodeCreateResponse.
    /// </summary>
    public class AlipayOpenMiniHmcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 异形码图片链接地址
        /// </summary>
        [JsonPropertyName("hm_code_url")]
        public string HmCodeUrl { get; set; }
    }
}
