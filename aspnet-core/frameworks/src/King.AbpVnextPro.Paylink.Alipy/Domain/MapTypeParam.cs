using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MapTypeParam Data Structure.
    /// </summary>
    public class MapTypeParam : AlipayObject
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
