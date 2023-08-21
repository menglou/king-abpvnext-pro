using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossBaseInstanceOperatetraceQueryResponse.
    /// </summary>
    public class AlipayBossBaseInstanceOperatetraceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [JsonPropertyName("operate_traces")]
        public BPOpenApiTicketOperateTraces OperateTraces { get; set; }
    }
}
