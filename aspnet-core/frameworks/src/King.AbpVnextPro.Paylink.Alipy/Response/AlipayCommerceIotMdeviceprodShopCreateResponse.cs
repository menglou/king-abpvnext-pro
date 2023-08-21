using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodShopCreateResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 虚拟门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
