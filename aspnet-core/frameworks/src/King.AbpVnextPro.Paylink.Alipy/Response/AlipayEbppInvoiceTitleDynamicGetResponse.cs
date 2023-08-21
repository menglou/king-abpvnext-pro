using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetResponse : AlipayResponse
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonPropertyName("title")]
        public InvoiceTitleModel Title { get; set; }
    }
}
