using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountBalanceFreezeResponse.
    /// </summary>
    public class AlipayBossFncSubaccountBalanceFreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 子户余额冻结结果open api数据传输对象
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountBalanceFreezeResultOpenApiDTO ResultSet { get; set; }
    }
}
