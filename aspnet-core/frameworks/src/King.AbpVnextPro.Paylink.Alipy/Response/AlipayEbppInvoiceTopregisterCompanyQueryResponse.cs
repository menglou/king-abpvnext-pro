using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterCompanyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterCompanyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 企业税务信息查询输出
        /// </summary>
        [JsonPropertyName("result")]
        public InvoiceCompanyQueryResult Result { get; set; }
    }
}
