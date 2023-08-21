using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenEchoSendModel Data Structure.
    /// </summary>
    public class AlipayOpenEchoSendModel : AlipayObject
    {
        /// <summary>
        /// city
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
