using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoSignFlowCreateResponse.
    /// </summary>
    public class AlipayEcoSignFlowCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 流程Id
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
