using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbdishPropertyValueInfo Data Structure.
    /// </summary>
    public class KbdishPropertyValueInfo : AlipayObject
    {
        /// <summary>
        /// 属性值排序字段，从1一直递增到5
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 销售属性值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
