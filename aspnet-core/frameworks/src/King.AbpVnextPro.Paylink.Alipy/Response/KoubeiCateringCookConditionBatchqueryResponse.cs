using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringCookConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringCookConditionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑菜谱模型列表
        /// </summary>
        [JsonPropertyName("kb_dish_cook_page_info")]
        public PaginationCook KbDishCookPageInfo { get; set; }
    }
}
