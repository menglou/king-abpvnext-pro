using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosMaterialDeleteModel : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
