using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [JsonPropertyName("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
