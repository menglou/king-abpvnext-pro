using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiShopMallPageQueryModel Data Structure.
    /// </summary>
    public class KoubeiShopMallPageQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
