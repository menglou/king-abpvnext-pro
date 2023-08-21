using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundTransInvoiceSyncdataModifyResponse.
    /// </summary>
    public class AlipayFundTransInvoiceSyncdataModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 票据详情页url
        /// </summary>
        [JsonPropertyName("invoice_url")]
        public string InvoiceUrl { get; set; }
    }
}
