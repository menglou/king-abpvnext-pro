using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolCertNumQueryResponse.
    /// </summary>
    public class AlipayMarketingToolCertNumQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 凭证可用点数列表。
        /// </summary>
        [JsonPropertyName("cert_available_num")]
        public List<CertAvailableNumVO> CertAvailableNum { get; set; }
    }
}
