using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAlipaypointBudgetlibQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAlipaypointBudgetlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 集分宝预算库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }
    }
}
