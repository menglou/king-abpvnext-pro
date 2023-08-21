using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对应模型最新版本号
        /// </summary>
        [JsonPropertyName("model_version")]
        public string ModelVersion { get; set; }
    }
}
