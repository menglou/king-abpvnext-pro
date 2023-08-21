using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTaskProcessResponse.
    /// </summary>
    public class AlipayBossBaseProcessTaskProcessResponse : AlipayResponse
    {
        /// <summary>
        /// 流程实例数据
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
