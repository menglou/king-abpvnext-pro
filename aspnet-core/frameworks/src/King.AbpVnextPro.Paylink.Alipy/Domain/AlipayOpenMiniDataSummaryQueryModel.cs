using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataSummaryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataSummaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求数据的日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }
    }
}
