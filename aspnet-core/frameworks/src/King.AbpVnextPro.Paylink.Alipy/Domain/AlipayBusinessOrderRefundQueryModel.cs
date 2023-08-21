﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessOrderRefundQueryModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderRefundQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款请求号，和退款时的退款请求号refund_request_no保持一致。若该参数为空则认为时整单退款查询，返回订单中所有的退款信息
        /// </summary>
        [JsonPropertyName("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
