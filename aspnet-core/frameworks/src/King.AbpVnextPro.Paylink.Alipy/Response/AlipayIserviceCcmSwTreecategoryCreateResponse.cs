using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
