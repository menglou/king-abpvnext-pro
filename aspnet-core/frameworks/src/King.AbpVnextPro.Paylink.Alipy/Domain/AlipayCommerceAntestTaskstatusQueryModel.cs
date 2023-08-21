using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestTaskstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }
    }
}
