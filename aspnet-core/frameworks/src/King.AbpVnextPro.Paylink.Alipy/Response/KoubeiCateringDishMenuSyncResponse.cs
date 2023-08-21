using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishMenuSyncResponse.
    /// </summary>
    public class KoubeiCateringDishMenuSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑菜谱id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }
    }
}
