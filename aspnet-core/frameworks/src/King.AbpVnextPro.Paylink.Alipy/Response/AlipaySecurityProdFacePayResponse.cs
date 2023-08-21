using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdFacePayResponse.
    /// </summary>
    public class AlipaySecurityProdFacePayResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("aa")]
        public string Aa { get; set; }
    }
}
