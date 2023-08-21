using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    public class MyObjectDdd : AlipayObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [JsonPropertyName("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonPropertyName("param")]
        public string Param { get; set; }
    }
}
