using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSymbolBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSymbolBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 股票唯一编码，symbol=code.market
        /// </summary>
        [JsonPropertyName("symbols")]
        public List<string> Symbols { get; set; }
    }
}
