using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserCertdocUrlQueryResponse.
    /// </summary>
    public class AlipayUserCertdocUrlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
