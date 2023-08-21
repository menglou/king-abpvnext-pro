using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishRuleCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishRuleCreateModel : AlipayObject
    {
        /// <summary>
        /// 菜品规则通用模型
        /// </summary>
        [JsonPropertyName("kb_dish_rule_info")]
        public KbdishRuleInfo KbDishRuleInfo { get; set; }
    }
}
