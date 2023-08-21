using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishCommgroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCommgroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 客制化组分页信息
        /// </summary>
        [JsonPropertyName("kb_dish_group_page_info")]
        public PaginationCommGroup KbDishGroupPageInfo { get; set; }
    }
}
