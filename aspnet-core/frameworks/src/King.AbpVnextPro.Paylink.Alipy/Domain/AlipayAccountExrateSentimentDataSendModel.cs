using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountExrateSentimentDataSendModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateSentimentDataSendModel : AlipayObject
    {
        /// <summary>
        /// 国家制裁提交数据内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
