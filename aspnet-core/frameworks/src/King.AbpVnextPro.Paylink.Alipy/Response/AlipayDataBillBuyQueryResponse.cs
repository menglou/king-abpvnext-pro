﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataBillBuyQueryResponse.
    /// </summary>
    public class AlipayDataBillBuyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易流水详情
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<TradeItemResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务明细总数。返回满足查询条件的明细的数量
        /// </summary>
        [JsonPropertyName("total_size")]
        public string TotalSize { get; set; }
    }
}
