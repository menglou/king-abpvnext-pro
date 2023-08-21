﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmModifyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 内容id：该活动/商品入库成功之后，会将该活动/商品的id返回，作为商品/活动的内容id
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }
    }
}
