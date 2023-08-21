using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonPropertyName("activities")]
        public List<MarketActivityInfo> Activities { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [JsonPropertyName("paginator")]
        public Paginator Paginator { get; set; }
    }
}
