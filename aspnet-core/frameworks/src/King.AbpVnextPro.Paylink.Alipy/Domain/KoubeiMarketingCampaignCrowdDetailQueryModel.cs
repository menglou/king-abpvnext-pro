using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 人群组ID，人群组创建成功时返回的ID
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }
    }
}
