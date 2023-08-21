using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolRulegroupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 规则组ID
        /// </summary>
        [JsonPropertyName("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
