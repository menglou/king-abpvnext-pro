using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonPropertyName("member_template_ids")]
        public List<string> MemberTemplateIds { get; set; }
    }
}
