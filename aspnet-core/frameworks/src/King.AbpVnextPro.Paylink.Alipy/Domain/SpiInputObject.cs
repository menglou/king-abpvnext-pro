using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SpiInputObject Data Structure.
    /// </summary>
    public class SpiInputObject : AlipayObject
    {
        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }
    }
}
