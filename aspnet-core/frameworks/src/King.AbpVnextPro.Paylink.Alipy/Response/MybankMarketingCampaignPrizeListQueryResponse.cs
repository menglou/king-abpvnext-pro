using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListQueryResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品列表
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<PrizeModel> PrizeList { get; set; }

        /// <summary>
        /// 奖品总个数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
