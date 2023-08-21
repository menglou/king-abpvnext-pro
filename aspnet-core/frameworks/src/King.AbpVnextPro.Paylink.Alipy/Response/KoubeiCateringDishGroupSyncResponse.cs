using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncResponse.
    /// </summary>
    public class KoubeiCateringDishGroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 组模型
        /// </summary>
        [JsonPropertyName("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }
    }
}
