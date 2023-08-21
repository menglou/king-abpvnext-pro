using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 调用API新增计划后，返回的计划ID和该计划下所属的单元ID列表
        /// </summary>
        [JsonPropertyName("add_plan_group_result")]
        public AddPlanGroupResult AddPlanGroupResult { get; set; }
    }
}
