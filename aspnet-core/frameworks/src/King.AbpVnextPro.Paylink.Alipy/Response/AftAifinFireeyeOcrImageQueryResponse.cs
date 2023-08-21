using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AftAifinFireeyeOcrImageQueryResponse.
    /// </summary>
    public class AftAifinFireeyeOcrImageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果字段，这个是一个JSON字符串
        /// </summary>
        [JsonPropertyName("content")]
        public OcrIdentifyResult Content { get; set; }
    }
}
