using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanQueryModel : AlipayObject
    {
        /// <summary>
        /// 充值方案ID
        /// </summary>
        [JsonPropertyName("promotion_plan_id")]
        public string PromotionPlanId { get; set; }
    }
}
