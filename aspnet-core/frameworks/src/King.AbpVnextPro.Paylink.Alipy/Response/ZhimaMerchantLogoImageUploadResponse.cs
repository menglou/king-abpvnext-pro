using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaMerchantLogoImageUploadResponse.
    /// </summary>
    public class ZhimaMerchantLogoImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传图片后生成的图片地址
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
