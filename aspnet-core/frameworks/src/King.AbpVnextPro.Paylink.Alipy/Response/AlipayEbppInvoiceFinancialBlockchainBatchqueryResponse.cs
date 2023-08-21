using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFinancialBlockchainBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票列表
        /// </summary>
        [JsonPropertyName("invoice_element_list")]
        public List<InvoiceElementModel> InvoiceElementList { get; set; }
    }
}
