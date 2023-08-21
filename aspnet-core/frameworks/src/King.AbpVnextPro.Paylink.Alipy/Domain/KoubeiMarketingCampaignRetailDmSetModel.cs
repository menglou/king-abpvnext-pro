﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmSetModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmSetModel : AlipayObject
    {
        /// <summary>
        /// 下架时间，仅上架操作时使用，必须晚于当前时间
        /// </summary>
        [JsonPropertyName("campaign_end_time")]
        public string CampaignEndTime { get; set; }

        /// <summary>
        /// 内容ID，调用koubei.marketing.campaign.retail.dm.create创建内容时返回的内容ID
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 上下架操作类型，上架：ONLINE，下架：OFFLINE，注意：请先调用创建内容接口再进行上架操作，下架内容不得再上架。
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }
    }
}
