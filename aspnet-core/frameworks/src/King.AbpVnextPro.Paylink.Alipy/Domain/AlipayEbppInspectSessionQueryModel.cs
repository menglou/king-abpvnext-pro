using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInspectSessionQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInspectSessionQueryModel : AlipayObject
    {
        /// <summary>
        /// id
        /// </summary>
        [JsonPropertyName("log_name")]
        public string LogName { get; set; }
    }
}
