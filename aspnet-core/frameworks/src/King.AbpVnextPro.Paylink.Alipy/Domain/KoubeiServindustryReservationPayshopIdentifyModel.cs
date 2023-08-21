using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationPayshopIdentifyModel Data Structure.
    /// </summary>
    public class KoubeiServindustryReservationPayshopIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
