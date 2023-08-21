using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// TuitionMoneyDTO Data Structure.
    /// </summary>
    public class TuitionMoneyDTO : AlipayObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额最小单位
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
