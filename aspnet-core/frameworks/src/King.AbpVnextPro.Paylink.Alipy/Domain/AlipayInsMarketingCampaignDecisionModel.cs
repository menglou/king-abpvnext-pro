﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsMarketingCampaignDecisionModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingCampaignDecisionModel : AlipayObject
    {
        /// <summary>
        /// 描述营销活动涉及的业务类型  1：平台险业务
        /// </summary>
        [JsonPropertyName("business_type")]
        public long BusinessType { get; set; }

        /// <summary>
        /// 营销市场列表
        /// </summary>
        [JsonPropertyName("market_types")]
        public List<long> MarketTypes { get; set; }

        /// <summary>
        /// 保险营销平台营销标的标识
        /// </summary>
        [JsonPropertyName("mkt_obj_id")]
        public string MktObjId { get; set; }

        /// <summary>
        /// 保险营销平台的营销标的类型  1：淘宝商品
        /// </summary>
        [JsonPropertyName("mkt_obj_type")]
        public long MktObjType { get; set; }

        /// <summary>
        /// 请求流水id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
