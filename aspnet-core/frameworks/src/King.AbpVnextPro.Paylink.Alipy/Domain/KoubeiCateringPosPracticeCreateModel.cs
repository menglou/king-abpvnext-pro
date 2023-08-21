using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosPracticeCreateModel : AlipayObject
    {
        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonPropertyName("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
