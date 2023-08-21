using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// biz_result
        /// </summary>
        [JsonPropertyName("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
