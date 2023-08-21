using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserFunditemGetResponse.
    /// </summary>
    public class AlipayUserFunditemGetResponse : AlipayResponse
    {
        /// <summary>
        /// 查询得到的消费记录详细信息（主记录+资金明细列表）
        /// </summary>
        [JsonPropertyName("fund_detail_item_aopmodel")]
        public FundDetailItemAOPModel FundDetailItemAopmodel { get; set; }
    }
}
