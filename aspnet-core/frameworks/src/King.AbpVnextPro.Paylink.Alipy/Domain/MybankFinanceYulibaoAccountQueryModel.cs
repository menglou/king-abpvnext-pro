using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码。余利宝场景固定为 001529。
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }
    }
}
