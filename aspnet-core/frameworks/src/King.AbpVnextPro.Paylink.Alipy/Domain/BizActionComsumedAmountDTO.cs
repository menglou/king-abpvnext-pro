using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BizActionComsumedAmountDTO Data Structure.
    /// </summary>
    public class BizActionComsumedAmountDTO : AlipayObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }

        /// <summary>
        /// 外部系统bizUkId
        /// </summary>
        [JsonPropertyName("biz_uk_id")]
        public string BizUkId { get; set; }

        /// <summary>
        /// 占用金额
        /// </summary>
        [JsonPropertyName("consumed_amount")]
        public string ConsumedAmount { get; set; }
    }
}
