using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("activities")]
        public List<MerchantOnlineActivityOpenModel> Activities { get; set; }
    }
}
