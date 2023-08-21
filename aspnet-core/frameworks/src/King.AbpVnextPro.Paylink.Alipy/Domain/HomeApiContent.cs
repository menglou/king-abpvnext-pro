using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// HomeApiContent Data Structure.
    /// </summary>
    public class HomeApiContent : AlipayObject
    {
        /// <summary>
        /// 参数的key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数value值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
