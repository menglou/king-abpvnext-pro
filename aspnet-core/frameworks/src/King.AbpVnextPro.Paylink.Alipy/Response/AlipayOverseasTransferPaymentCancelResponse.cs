using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentCancelResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
