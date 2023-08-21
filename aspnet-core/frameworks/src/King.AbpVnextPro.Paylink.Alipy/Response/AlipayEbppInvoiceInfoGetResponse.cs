using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInfoGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceInfoGetResponse : AlipayResponse
    {
        /// <summary>
        /// 电子发票详情模型
        /// </summary>
        [JsonPropertyName("invoice_model")]
        public InvoiceModelContent InvoiceModel { get; set; }
    }
}
