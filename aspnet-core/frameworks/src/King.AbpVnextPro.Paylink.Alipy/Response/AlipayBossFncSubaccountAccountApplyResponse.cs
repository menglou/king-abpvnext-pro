using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountApplyResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请子户结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public ApplySubAccountAndBindResultDTO ResultSet { get; set; }
    }
}
