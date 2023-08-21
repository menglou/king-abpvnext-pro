using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSilanApigrayQueryModel : AlipayObject
    {
        /// <summary>
        /// param
        /// </summary>
        [JsonPropertyName("param_1")]
        public string Param1 { get; set; }
    }
}
