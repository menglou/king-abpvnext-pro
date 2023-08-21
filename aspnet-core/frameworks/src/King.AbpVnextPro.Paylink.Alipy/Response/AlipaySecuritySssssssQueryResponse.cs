using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecuritySssssssQueryResponse.
    /// </summary>
    public class AlipaySecuritySssssssQueryResponse : AlipayResponse
    {
        /// <summary>
        /// af
        /// </summary>
        [JsonPropertyName("adfad")]
        public string Adfad { get; set; }
    }
}
