using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncInvoicreceiptQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoicreceiptQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开票单据返回对象
        /// </summary>
        [JsonPropertyName("result_set")]
        public ArInvoiceReceiptQueryOpenApiDTO ResultSet { get; set; }
    }
}
