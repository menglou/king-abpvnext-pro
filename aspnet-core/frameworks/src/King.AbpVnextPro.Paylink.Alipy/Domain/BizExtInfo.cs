using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BizExtInfo Data Structure.
    /// </summary>
    public class BizExtInfo : AlipayObject
    {
        /// <summary>
        /// key-value
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
