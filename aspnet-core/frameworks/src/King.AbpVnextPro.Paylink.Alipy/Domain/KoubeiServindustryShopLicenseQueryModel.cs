using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiServindustryShopLicenseQueryModel Data Structure.
    /// </summary>
    public class KoubeiServindustryShopLicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
