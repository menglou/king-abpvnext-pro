using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceFundFundFixedprofitQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }
    }
}
