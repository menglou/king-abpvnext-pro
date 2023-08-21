using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// H5应用详情
        /// </summary>
        [JsonPropertyName("activity")]
        public FengdieActivity Activity { get; set; }
    }
}
