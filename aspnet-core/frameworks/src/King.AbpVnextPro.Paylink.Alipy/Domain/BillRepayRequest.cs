using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BillRepayRequest Data Structure.
    /// </summary>
    public class BillRepayRequest : AlipayObject
    {
        /// <summary>
        /// 还款金额
        /// </summary>
        [JsonPropertyName("repay_amt")]
        public MultiCurrencyMoneyVO RepayAmt { get; set; }
    }
}
