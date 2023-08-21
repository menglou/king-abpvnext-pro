using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveBillInferenceQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
