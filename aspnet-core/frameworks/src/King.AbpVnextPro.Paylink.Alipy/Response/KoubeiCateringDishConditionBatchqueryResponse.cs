using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringDishConditionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品分页信息
        /// </summary>
        [JsonPropertyName("kb_dish_page_info")]
        public PaginationDish KbDishPageInfo { get; set; }
    }
}
