using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCertificateQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCertificateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 获得证书信息
        /// </summary>
        [JsonPropertyName("certificates")]
        public List<CreditBankCertificateExperience> Certificates { get; set; }
    }
}
