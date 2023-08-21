using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdNopidBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdNopidBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 111
        /// </summary>
        [JsonPropertyName("rthreemcc")]
        public string Rthreemcc { get; set; }
    }
}
