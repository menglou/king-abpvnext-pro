using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppMerchantMeterialUploadResponse.
    /// </summary>
    public class AlipayEbppMerchantMeterialUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 文件对应的MD5值, 用于文件完整性校验
        /// </summary>
        [JsonPropertyName("md_5")]
        public string Md5 { get; set; }
    }
}
