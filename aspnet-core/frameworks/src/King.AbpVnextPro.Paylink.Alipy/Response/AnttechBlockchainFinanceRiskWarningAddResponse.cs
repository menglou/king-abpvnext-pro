using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceRiskWarningAddResponse.
    /// </summary>
    public class AnttechBlockchainFinanceRiskWarningAddResponse : AlipayResponse
    {
        /// <summary>
        /// 提交结果
        /// </summary>
        [JsonPropertyName("submit_result")]
        public string SubmitResult { get; set; }
    }
}
