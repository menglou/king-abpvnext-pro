using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SpiOutputObject Data Structure.
    /// </summary>
    public class SpiOutputObject : AlipayObject
    {
        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }
    }
}
