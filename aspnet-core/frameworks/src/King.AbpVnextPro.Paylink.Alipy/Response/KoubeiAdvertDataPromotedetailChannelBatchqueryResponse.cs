﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailChannelBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotedetailChannelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [JsonPropertyName("data")]
        public List<PromoteDetailChannelModel> Data { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
