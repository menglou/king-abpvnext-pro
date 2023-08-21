using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncSettleSettlementbillCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleSettlementbillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 返回参数
        /// </summary>
        [JsonPropertyName("result_set")]
        public SettlementbillOpenApiDTO ResultSet { get; set; }
    }
}
