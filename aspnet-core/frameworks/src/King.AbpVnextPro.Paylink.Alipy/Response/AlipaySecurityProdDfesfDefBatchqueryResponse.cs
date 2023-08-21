using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("ded")]
        public string Ded { get; set; }
    }
}
