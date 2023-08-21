using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示内容数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
