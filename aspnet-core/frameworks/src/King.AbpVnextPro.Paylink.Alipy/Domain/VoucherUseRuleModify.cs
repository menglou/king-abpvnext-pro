using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// VoucherUseRuleModify Data Structure.
    /// </summary>
    public class VoucherUseRuleModify : AlipayObject
    {
        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [JsonPropertyName("voucher_valid_period")]
        public VoucherValidPeriodModify VoucherValidPeriod { get; set; }
    }
}
