using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryModel Data Structure.
    /// </summary>
    public class AnttechAiCvTfjsModelversionQueryModel : AlipayObject
    {
        /// <summary>
        /// tfjs端模型code
        /// </summary>
        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }
    }
}
