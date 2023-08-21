using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberAuthApplyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMemberAuthApplyModel : AlipayObject
    {
        /// <summary>
        /// token
        /// </summary>
        [JsonPropertyName("auth_token")]
        public string AuthToken { get; set; }
    }
}
