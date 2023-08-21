using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoBenefitCheckavailableModel Data Structure.
    /// </summary>
    public class AlipayInsAutoBenefitCheckavailableModel : AlipayObject
    {
        /// <summary>
        /// 支付宝权益编码标识
        /// </summary>
        [JsonPropertyName("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// 预留扩展字段
        /// </summary>
        [JsonPropertyName("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 支付宝用户标识
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
