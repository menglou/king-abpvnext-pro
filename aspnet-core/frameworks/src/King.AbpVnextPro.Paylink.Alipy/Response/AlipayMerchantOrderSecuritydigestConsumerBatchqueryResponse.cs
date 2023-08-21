﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantOrderSecuritydigestConsumerBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSecuritydigestConsumerBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 下一次请求的end_time（用于分页查询）
        /// </summary>
        [JsonPropertyName("next_end_time")]
        public string NextEndTime { get; set; }

        /// <summary>
        /// 订单信息列表，当存在符合条件的订单时，则返回订单信息；
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<AlipayOrderDataOpenapiResultInfo> OrderList { get; set; }
    }
}
