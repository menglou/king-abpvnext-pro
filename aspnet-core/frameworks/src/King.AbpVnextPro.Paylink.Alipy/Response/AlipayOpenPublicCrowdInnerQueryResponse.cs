using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicCrowdInnerQueryResponse.
    /// </summary>
    public class AlipayOpenPublicCrowdInnerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人群摘要信息
        /// </summary>
        [JsonPropertyName("crowd_summary")]
        public CrowdSummary CrowdSummary { get; set; }
    }
}
