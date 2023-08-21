using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// IsvMerchantInfo Data Structure.
    /// </summary>
    public class IsvMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 门店ID列表
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
