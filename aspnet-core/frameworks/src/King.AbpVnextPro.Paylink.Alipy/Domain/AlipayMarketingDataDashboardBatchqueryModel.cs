﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDashboardBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数，最大每页30条
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }
    }
}
