using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BPOpenApiTicketOperateTraces Data Structure.
    /// </summary>
    public class BPOpenApiTicketOperateTraces : AlipayObject
    {
        /// <summary>
        /// 操作记录
        /// </summary>
        [JsonPropertyName("operate_traces")]
        public List<BPOpenApiTicketOperateTrace> OperateTraces { get; set; }
    }
}
