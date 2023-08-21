using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("business_id")]
        public long BusinessId { get; set; }
    }
}
