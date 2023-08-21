using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishRuleQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRuleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 规则的返回集合
        /// </summary>
        [JsonPropertyName("kb_dish_rule_info_list")]
        public List<KbdishRuleInfo> KbDishRuleInfoList { get; set; }
    }
}
