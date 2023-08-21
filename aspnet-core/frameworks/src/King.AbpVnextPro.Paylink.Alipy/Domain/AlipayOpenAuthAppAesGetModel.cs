using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppAesGetModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppAesGetModel : AlipayObject
    {
        /// <summary>
        /// 商家应用appId
        /// </summary>
        [JsonPropertyName("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
