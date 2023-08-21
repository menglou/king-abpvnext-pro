using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// TimeRange Data Structure.
    /// </summary>
    public class TimeRange : AlipayObject
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end")]
        public string End { get; set; }
    }
}
