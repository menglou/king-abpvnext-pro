using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityShopOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOnlineModel : AlipayObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
