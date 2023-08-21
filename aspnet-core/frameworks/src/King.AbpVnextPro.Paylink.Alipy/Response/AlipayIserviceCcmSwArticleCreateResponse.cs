using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
