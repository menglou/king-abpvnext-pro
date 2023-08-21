using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeSendQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeSendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中奖信息列表
        /// </summary>
        [JsonPropertyName("prize_detail_list")]
        public List<PrizeDetail> PrizeDetailList { get; set; }
    }
}
