using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAntestReportQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 测试报告页url
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
