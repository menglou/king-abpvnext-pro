using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemInfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }
    }
}
