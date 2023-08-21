using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentDisburseResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentDisburseResponse : AlipayResponse
    {
        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 批量结果返回
        /// </summary>
        [JsonPropertyName("transaction_results")]
        public string TransactionResults { get; set; }
    }
}
