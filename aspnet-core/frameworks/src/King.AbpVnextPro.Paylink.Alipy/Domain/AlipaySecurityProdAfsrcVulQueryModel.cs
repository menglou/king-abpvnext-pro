using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulQueryModel : AlipayObject
    {
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonPropertyName("vul_id")]
        public long VulId { get; set; }
    }
}
