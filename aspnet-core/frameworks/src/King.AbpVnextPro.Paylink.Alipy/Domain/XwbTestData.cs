using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// XwbTestData Data Structure.
    /// </summary>
    public class XwbTestData : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("s")]
        public string S { get; set; }
    }
}
