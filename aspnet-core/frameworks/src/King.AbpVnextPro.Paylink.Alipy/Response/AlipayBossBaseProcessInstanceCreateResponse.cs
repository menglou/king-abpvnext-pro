using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建的实例
        /// </summary>
        [JsonPropertyName("instance")]
        public BPOpenApiInstance Instance { get; set; }
    }
}
