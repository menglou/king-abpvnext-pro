using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanGetResponse : AlipayResponse
    {
        /// <summary>
        /// 计划详情
        /// </summary>
        [JsonPropertyName("plan_result")]
        public AdPlan PlanResult { get; set; }
    }
}
