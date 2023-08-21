using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromotionplanModifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromotionplanModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 充值方案信息，返回修改后的充值方案信息
        /// </summary>
        [JsonPropertyName("promotion_plan")]
        public PayForPrivilegePromotionPlanInfo PromotionPlan { get; set; }
    }
}
