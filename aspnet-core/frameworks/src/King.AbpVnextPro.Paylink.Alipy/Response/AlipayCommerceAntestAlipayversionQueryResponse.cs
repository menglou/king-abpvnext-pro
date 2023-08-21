using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAntestAlipayversionQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestAlipayversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝版本
        /// </summary>
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
