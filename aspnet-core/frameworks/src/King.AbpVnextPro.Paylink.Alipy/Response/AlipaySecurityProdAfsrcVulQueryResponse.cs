using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonPropertyName("data")]
        public VulInfo Data { get; set; }
    }
}
