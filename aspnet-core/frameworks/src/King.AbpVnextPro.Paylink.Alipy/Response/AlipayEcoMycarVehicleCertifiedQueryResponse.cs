using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleCertifiedQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleCertifiedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证结果列表
        /// </summary>
        [JsonPropertyName("cert_list")]
        public List<PlateNoCertDto> CertList { get; set; }
    }
}
