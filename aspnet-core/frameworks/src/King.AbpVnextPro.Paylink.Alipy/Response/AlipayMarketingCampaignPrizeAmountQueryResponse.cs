using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品剩余数量，数值
        /// </summary>
        [JsonPropertyName("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
