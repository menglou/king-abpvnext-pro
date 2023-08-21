using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
