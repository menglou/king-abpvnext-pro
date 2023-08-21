using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// TuitionOrderExtendParam Data Structure.
    /// </summary>
    public class TuitionOrderExtendParam : AlipayObject
    {
        /// <summary>
        /// 支付后回跳地址
        /// </summary>
        [JsonPropertyName("returnback_url")]
        public string ReturnbackUrl { get; set; }
    }
}
