using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTransferConfirmResponse.
    /// </summary>
    public class AlipayOverseasTransferConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// {}
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 汇款id
        /// </summary>
        [JsonPropertyName("transfer_id")]
        public string TransferId { get; set; }
    }
}
