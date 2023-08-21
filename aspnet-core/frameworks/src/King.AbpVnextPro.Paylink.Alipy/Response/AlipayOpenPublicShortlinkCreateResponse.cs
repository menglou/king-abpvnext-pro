using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [JsonPropertyName("shortlink")]
        public string Shortlink { get; set; }
    }
}
