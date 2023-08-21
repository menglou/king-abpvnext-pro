using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainShopCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝内部店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
