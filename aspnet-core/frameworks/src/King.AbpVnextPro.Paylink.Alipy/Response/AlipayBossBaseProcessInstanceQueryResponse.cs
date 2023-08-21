using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 流程实例内容
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
