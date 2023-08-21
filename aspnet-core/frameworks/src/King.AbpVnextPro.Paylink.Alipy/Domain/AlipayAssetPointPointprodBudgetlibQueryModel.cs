using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibQueryModel Data Structure.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 预算库编码
        /// </summary>
        [JsonPropertyName("budget_code")]
        public string BudgetCode { get; set; }
    }
}
