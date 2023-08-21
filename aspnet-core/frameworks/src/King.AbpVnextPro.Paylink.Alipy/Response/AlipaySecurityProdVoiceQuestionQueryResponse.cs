using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdVoiceQuestionQueryResponse.
    /// </summary>
    public class AlipaySecurityProdVoiceQuestionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 问题推荐结果
        /// </summary>
        [JsonPropertyName("question_result")]
        public string QuestionResult { get; set; }
    }
}
