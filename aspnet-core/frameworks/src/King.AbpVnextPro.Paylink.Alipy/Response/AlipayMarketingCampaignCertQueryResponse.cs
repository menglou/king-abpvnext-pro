﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCertQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCertQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户还有效的凭证详细列表
        /// </summary>
        [JsonPropertyName("subcert_list")]
        public List<KnCertSendOrderDetail> SubcertList { get; set; }

        /// <summary>
        /// 总的真正还可用的剩余有效点数
        /// </summary>
        [JsonPropertyName("total_remain_point")]
        public long TotalRemainPoint { get; set; }
    }
}
