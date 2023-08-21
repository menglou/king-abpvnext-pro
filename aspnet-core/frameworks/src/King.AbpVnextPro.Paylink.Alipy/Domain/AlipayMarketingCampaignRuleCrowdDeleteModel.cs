﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignRuleCrowdDeleteModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignRuleCrowdDeleteModel : AlipayObject
    {
        /// <summary>
        /// 签约商户下属子机构唯一编号
        /// </summary>
        [JsonPropertyName("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 对没有在使用的规则进行删除
        /// </summary>
        [JsonPropertyName("ruleid")]
        public string Ruleid { get; set; }
    }
}
