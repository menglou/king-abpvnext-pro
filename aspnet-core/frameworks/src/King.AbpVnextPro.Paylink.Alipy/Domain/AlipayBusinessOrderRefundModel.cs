﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 订单退款环境信息
        /// </summary>
        [JsonPropertyName("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款支付工具列表
        /// </summary>
        [JsonPropertyName("refund_paytool_list")]
        public List<PaytoolRefundRequestDetail> RefundPaytoolList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求号。若退款请求号不为空，则必需传入refund_paytools_list。  若不传入退款请求号，同时refund_paytools_list为空，则认为是全额退款。
        /// </summary>
        [JsonPropertyName("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
