using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectImageUploadResponse.
    /// </summary>
    public class AntMerchantExpandIndirectImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片在文件存储平台的标识
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }
    }
}
