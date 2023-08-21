using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceAntestTaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public long BatchId { get; set; }
    }
}
