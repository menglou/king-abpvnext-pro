using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategorySyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualcategorySyncModel : AlipayObject
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [JsonPropertyName("catetory_info")]
        public KbdishVirtualCatetorySimplifyInfo CatetoryInfo { get; set; }
    }
}
