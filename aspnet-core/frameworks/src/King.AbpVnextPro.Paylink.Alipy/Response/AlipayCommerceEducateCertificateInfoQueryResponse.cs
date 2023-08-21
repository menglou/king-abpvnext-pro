using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateCertificateInfoQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCertificateInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 证书列表
        /// </summary>
        [JsonPropertyName("certificates")]
        public List<StudentCertificate> Certificates { get; set; }
    }
}
