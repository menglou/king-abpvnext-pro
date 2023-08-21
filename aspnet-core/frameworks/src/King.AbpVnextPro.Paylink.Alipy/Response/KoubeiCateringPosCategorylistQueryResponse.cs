using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosCategorylistQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategorylistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜类列表
        /// </summary>
        [JsonPropertyName("category_entity_list")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
