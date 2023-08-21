﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateCreateResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonPropertyName("member_template_id")]
        public string MemberTemplateId { get; set; }
    }
}
