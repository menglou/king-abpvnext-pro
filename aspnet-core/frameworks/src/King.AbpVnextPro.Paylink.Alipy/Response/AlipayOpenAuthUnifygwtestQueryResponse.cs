using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryResponse.
    /// </summary>
    public class AlipayOpenAuthUnifygwtestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }
    }
}
