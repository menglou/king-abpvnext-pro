using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PromotePagePropertyInstance Data Structure.
    /// </summary>
    public class PromotePagePropertyInstance : AlipayObject
    {
        /// <summary>
        /// 留资属性key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 留资属性名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 留资属性实例值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
