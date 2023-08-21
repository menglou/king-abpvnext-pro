using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MapParameter Data Structure.
    /// </summary>
    public class MapParameter : AlipayObject
    {
        /// <summary>
        /// 参数的名字
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
