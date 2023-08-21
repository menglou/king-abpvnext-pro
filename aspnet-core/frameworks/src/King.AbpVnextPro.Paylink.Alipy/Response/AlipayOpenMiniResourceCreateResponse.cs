using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniResourceCreateResponse.
    /// </summary>
    public class AlipayOpenMiniResourceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 流量位id
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }
    }
}
