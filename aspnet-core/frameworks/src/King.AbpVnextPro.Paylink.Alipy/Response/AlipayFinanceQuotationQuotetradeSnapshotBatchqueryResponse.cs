using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 快照对象
        /// </summary>
        [JsonPropertyName("data")]
        public List<SnapshotDTO> Data { get; set; }
    }
}
