using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyConfirmResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 确认结果
        /// </summary>
        [JsonPropertyName("confirm_success")]
        public bool ConfirmSuccess { get; set; }

        /// <summary>
        /// 成功或失败，本版本废弃
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
