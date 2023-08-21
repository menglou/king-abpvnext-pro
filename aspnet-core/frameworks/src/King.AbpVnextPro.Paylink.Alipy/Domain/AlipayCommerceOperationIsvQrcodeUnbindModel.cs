using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvQrcodeUnbindModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationIsvQrcodeUnbindModel : AlipayObject
    {
        /// <summary>
        /// 微信公众号二维码码值
        /// </summary>
        [JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; }
    }
}
