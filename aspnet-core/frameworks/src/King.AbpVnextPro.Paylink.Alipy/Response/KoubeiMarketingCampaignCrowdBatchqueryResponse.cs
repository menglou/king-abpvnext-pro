﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignCrowdBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignCrowdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人群组的基本信息，id表示人群分组的ID，name表示人群分组的名称，status表示人群分组的状态，目前只有status=ENABLE有效状态才返回，已经删除的为DISABLE的不返回
        /// </summary>
        [JsonPropertyName("crowd_group_sets")]
        public string CrowdGroupSets { get; set; }

        /// <summary>
        /// 返回接记录的总条数
        /// </summary>
        [JsonPropertyName("total_number")]
        public string TotalNumber { get; set; }
    }
}
