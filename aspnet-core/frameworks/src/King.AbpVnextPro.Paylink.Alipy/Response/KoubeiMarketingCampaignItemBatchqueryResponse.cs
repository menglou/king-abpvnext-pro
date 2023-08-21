using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回商品券集合信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<PromoItemInfo> Items { get; set; }
    }
}
