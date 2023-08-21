using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppCommunityNoticePublishResponse.
    /// </summary>
    public class AlipayEbppCommunityNoticePublishResponse : AlipayResponse
    {
        /// <summary>
        /// 公告id
        /// </summary>
        [JsonPropertyName("alipay_notice_id")]
        public long AlipayNoticeId { get; set; }
    }
}
