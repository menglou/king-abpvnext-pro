﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayTradePageMergePayModel Data Structure.
    /// </summary>
    public class AlipayTradePageMergePayModel : AlipayObject
    {
        /// <summary>
        /// 子订单详情
        /// </summary>
        [JsonPropertyName("order_details")]
        public List<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// 如果已经和支付宝约定要求子订单明细必须同时支付成功或者同时支付失败则必须传入此参数，且该参数必须在商户端唯一，否则可以不需要填。
        /// </summary>
        [JsonPropertyName("out_merge_no")]
        public string OutMergeNo { get; set; }

        /// <summary>
        /// 请求合并的所有订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
