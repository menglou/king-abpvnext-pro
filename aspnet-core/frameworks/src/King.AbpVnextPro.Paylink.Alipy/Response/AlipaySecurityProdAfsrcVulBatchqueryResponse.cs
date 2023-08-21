using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdAfsrcVulBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 漏洞信息列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<VulList> Data { get; set; }
    }
}
