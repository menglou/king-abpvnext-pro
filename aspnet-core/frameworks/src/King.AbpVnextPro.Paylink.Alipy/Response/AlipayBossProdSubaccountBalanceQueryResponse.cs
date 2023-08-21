using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryResponse.
    /// </summary>
    public class AlipayBossProdSubaccountBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 子户余额信息
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountBalanceOpenApiDTO ResultSet { get; set; }
    }
}
