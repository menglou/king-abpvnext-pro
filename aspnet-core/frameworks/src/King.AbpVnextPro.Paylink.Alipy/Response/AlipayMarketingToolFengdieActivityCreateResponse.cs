using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// H5应用的唯一id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }
    }
}
