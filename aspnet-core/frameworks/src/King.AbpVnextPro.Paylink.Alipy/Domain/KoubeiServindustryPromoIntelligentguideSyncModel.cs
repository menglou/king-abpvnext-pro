﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideSyncModel : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 单商户下的门店交易数据列表
        /// </summary>
        [JsonPropertyName("trade_infos")]
        public List<IntelligentGuideTradeInfo> TradeInfos { get; set; }
    }
}
