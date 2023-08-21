using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AmapMapMapserviceTeseBatchqueryResponse.
    /// </summary>
    public class AmapMapMapserviceTeseBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("es")]
        public string Es { get; set; }
    }
}
