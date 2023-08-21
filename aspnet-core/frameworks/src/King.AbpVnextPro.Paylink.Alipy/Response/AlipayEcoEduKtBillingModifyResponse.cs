using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 如果成功，返回Y
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
