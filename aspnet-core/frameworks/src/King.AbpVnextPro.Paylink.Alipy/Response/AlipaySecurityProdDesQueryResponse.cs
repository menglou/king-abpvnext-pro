using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdDesQueryResponse.
    /// </summary>
    public class AlipaySecurityProdDesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("dee")]
        public GavintestNewLeveaOne Dee { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("string")]
        public string String { get; set; }
    }
}
