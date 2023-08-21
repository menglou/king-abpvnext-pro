using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAraterWaitratealgorankQueryResponse.
    /// </summary>
    public class AlipayOpenAppAraterWaitratealgorankQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待评价列表打分结果
        /// </summary>
        [JsonPropertyName("wait_rate_rank_items")]
        public List<WaitRateAlgoItem> WaitRateRankItems { get; set; }
    }
}
