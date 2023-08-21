using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountQueryResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询子户结果信息
        /// </summary>
        [JsonPropertyName("result_set")]
        public SubAccountInfoDTO ResultSet { get; set; }
    }
}
