using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoOuQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoOuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开票资料
        /// </summary>
        [JsonPropertyName("result_set")]
        public ApUserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
