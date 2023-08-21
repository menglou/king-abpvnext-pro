using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbdishTimeRangeInfo Data Structure.
    /// </summary>
    public class KbdishTimeRangeInfo : AlipayObject
    {
        /// <summary>
        /// 结束时间点
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 起始时间点
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
