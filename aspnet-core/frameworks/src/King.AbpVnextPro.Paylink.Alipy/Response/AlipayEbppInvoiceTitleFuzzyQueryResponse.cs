using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleFuzzyQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleFuzzyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 企业名称列表
        /// </summary>
        [JsonPropertyName("enterprise_name")]
        public List<string> EnterpriseName { get; set; }
    }
}
