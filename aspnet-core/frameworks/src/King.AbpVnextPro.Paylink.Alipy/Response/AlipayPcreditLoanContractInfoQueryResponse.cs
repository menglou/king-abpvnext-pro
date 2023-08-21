using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditLoanContractInfoQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanContractInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
