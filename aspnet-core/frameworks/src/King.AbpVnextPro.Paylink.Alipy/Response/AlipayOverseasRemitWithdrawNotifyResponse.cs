using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasRemitWithdrawNotifyResponse.
    /// </summary>
    public class AlipayOverseasRemitWithdrawNotifyResponse : AlipayResponse
    {
        /// <summary>
        /// JSON map
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
