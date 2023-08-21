﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicSummaryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicSummaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 上架：ON_LINE,下架：OFF_LINE，为空时查询全部
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
