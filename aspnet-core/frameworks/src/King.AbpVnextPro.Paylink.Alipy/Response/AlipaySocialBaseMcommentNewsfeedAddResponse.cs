using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseMcommentNewsfeedAddResponse.
    /// </summary>
    public class AlipaySocialBaseMcommentNewsfeedAddResponse : AlipayResponse
    {
        /// <summary>
        /// 新评论id
        /// </summary>
        [JsonPropertyName("newsfeed_id")]
        public string NewsfeedId { get; set; }
    }
}
