using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PeriodInfo Data Structure.
    /// </summary>
    public class PeriodInfo : AlipayObject
    {
        /// <summary>
        /// 单位
        /// </summary>
        [JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 周期值
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
