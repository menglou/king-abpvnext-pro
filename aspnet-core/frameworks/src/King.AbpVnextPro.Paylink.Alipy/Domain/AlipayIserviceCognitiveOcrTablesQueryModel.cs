using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrTablesQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrTablesQueryModel : AlipayObject
    {
        /// <summary>
        /// 图片base64后内容，大小控制在1M以内
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }
    }
}
