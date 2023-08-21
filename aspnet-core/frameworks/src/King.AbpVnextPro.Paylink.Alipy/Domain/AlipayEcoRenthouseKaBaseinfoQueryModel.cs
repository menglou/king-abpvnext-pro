using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// kaCode唯一标识
        /// </summary>
        [JsonPropertyName("ka_code")]
        public string KaCode { get; set; }
    }
}
