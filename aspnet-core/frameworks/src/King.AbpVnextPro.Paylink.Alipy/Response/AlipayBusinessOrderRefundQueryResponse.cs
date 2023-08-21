﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessOrderRefundQueryResponse.
    /// </summary>
    public class AlipayBusinessOrderRefundQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 退款时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 商户外部订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单累计退款金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("order_refund_amount")]
        public string OrderRefundAmount { get; set; }

        /// <summary>
        /// 本次查询的退款支付工具明细列表
        /// </summary>
        [JsonPropertyName("refund_paytool_list")]
        public List<PaytoolRefundResultDetail> RefundPaytoolList { get; set; }
    }
}
