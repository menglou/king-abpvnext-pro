using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCreateModel : AlipayObject
    {
        /// <summary>
        /// 复杂类型，参见AdPlan定义
        /// </summary>
        [JsonPropertyName("ad_plan")]
        public AdPlan AdPlan { get; set; }
    }
}
