using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneClaimNewreportCreateResponse.
    /// </summary>
    public class AlipayInsSceneClaimNewreportCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 保单单据号
        /// </summary>
        [JsonPropertyName("claim_report_no")]
        public string ClaimReportNo { get; set; }
    }
}
