using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<DishRecommend> DishList { get; set; }
    }
}
