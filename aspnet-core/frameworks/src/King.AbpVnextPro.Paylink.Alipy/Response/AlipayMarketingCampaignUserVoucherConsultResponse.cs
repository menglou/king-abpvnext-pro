﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 活动券领取咨询结果列表
        /// </summary>
        [JsonPropertyName("activity_consult_list")]
        public List<ActivityConsultInfo> ActivityConsultList { get; set; }
    }
}
