using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 反馈模板地址
        /// </summary>
        [JsonPropertyName("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
