using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveKgopenQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveKgopenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
