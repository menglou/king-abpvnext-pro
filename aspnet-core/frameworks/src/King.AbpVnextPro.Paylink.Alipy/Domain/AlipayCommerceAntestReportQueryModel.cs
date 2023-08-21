﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceAntestReportQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 测试任务id
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }
    }
}
