using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitPlanQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitPlanQueryModel : AlipayObject
    {
        /// <summary>
        /// 招商方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
