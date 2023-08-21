using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishCookQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCookQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜谱list
        /// </summary>
        [JsonPropertyName("kb_cook_list")]
        public List<KbdishCookInfo> KbCookList { get; set; }
    }
}
