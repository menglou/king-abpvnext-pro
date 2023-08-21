﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNfccardSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportNfccardSendModel : AlipayObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片状态。枚举值如下： *  FREEZE：冻结。 *  CANCEL：销卡。
        /// </summary>
        [JsonPropertyName("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        [JsonPropertyName("issue_org_no")]
        public string IssueOrgNo { get; set; }
    }
}
