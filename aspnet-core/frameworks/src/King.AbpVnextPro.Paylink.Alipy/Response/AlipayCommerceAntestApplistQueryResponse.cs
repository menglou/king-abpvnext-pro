using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAntestApplistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestApplistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<EcoAppInfo> Data { get; set; }
    }
}
