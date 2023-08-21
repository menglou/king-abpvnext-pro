using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 数据量
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 满足自定义报表规则的报表数据
        /// </summary>
        [JsonPropertyName("report_data")]
        public List<ReportDataItem> ReportData { get; set; }
    }
}
