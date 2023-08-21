using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsUnderwriteClaimReportQueryResponse.
    /// </summary>
    public class AlipayInsUnderwriteClaimReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 案件信息
        /// </summary>
        [JsonPropertyName("reports")]
        public List<InsClaimReport> Reports { get; set; }
    }
}
