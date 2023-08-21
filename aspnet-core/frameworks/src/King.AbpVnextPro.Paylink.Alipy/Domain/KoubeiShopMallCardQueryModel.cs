using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiShopMallCardQueryModel Data Structure.
    /// </summary>
    public class KoubeiShopMallCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
