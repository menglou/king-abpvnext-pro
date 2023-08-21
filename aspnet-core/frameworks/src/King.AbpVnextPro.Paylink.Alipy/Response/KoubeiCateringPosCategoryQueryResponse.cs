using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜类信息
        /// </summary>
        [JsonPropertyName("dish_category_entity")]
        public DishCategoryEntity DishCategoryEntity { get; set; }
    }
}
