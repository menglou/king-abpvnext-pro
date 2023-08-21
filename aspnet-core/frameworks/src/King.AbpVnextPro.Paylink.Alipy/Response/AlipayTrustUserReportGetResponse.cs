using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTrustUserReportGetResponse.
    /// </summary>
    public class AlipayTrustUserReportGetResponse : AlipayResponse
    {
        /// <summary>
        /// 报告内容，格式详见示例代码
        /// </summary>
        [JsonPropertyName("report")]
        public string Report { get; set; }
    }
}
