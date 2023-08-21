using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceMylogisticfinsysContractApplyResponse.
    /// </summary>
    public class AnttechBlockchainFinanceMylogisticfinsysContractApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }
    }
}
