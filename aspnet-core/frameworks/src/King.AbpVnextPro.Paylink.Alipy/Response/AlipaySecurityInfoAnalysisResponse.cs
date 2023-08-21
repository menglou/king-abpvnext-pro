using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityInfoAnalysisResponse.
    /// </summary>
    public class AlipaySecurityInfoAnalysisResponse : AlipayResponse
    {
        /// <summary>
        /// 风险标签
        /// </summary>
        [JsonPropertyName("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonPropertyName("risk_level")]
        public long RiskLevel { get; set; }
    }
}
