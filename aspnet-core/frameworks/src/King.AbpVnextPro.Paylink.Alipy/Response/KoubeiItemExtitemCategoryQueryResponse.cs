using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiItemExtitemCategoryQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 品类信息列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<ExtCategory> CategoryList { get; set; }
    }
}
