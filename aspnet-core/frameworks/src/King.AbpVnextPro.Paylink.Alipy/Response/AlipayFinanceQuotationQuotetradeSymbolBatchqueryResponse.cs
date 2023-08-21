using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 码表
        /// </summary>
        [JsonPropertyName("data")]
        public List<SymbolDTO> Data { get; set; }
    }
}
