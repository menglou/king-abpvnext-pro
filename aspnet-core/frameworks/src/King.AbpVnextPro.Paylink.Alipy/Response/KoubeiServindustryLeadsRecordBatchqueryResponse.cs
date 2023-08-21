﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiServindustryLeadsRecordBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryLeadsRecordBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 客资详情列表
        /// </summary>
        [JsonPropertyName("leads_order_info_list")]
        public List<LeadsOrderInfo> LeadsOrderInfoList { get; set; }

        /// <summary>
        /// 客资总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
