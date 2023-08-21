using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ScenicExtInfo Data Structure.
    /// </summary>
    public class ScenicExtInfo : AlipayObject
    {
        /// <summary>
        /// key的值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// value值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
