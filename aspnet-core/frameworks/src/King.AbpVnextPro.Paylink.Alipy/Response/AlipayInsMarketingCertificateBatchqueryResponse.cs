using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsMarketingCertificateBatchqueryResponse.
    /// </summary>
    public class AlipayInsMarketingCertificateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分页查询结果
        /// </summary>
        [JsonPropertyName("ins_certificate_pagination_list")]
        public InsCertificatePaginationList InsCertificatePaginationList { get; set; }
    }
}
