using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AutoMktTouchExtendInfoEntry Data Structure.
    /// </summary>
    public class AutoMktTouchExtendInfoEntry : AlipayObject
    {
        /// <summary>
        /// 扩展信息元素的Key值。
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展字段的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
