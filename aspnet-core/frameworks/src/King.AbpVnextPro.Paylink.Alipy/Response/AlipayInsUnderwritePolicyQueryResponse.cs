using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsUnderwritePolicyQueryResponse.
    /// </summary>
    public class AlipayInsUnderwritePolicyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保单
        /// </summary>
        [JsonPropertyName("policy")]
        public InsPolicy Policy { get; set; }
    }
}
