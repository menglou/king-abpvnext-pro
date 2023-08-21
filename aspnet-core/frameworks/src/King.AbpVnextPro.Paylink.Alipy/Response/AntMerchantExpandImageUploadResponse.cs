using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandImageUploadResponse.
    /// </summary>
    public class AntMerchantExpandImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图片在sfs中的标识
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }
    }
}
