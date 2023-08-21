using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainShopCreateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 车主平台创建的门店编号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }
    }
}
