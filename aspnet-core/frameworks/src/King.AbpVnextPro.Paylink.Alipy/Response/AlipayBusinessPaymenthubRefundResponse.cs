﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessPaymenthubRefundResponse.
    /// </summary>
    public class AlipayBusinessPaymenthubRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 聚合支付的支付渠道，支付宝分配。
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 退款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款指令id，支付宝针对每一笔退款请求生成的唯一退款凭证号
        /// </summary>
        [JsonPropertyName("refund_id")]
        public List<string> RefundId { get; set; }

        /// <summary>
        /// 退款请求号，对应一笔业务订单下的一次退款请求，不退款请求需保证请求号唯一
        /// </summary>
        [JsonPropertyName("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 退款状态，目前支持如下值：  SUCCESS（退款成功），该状态表示该笔退款已成功处理；  FAIL（退款失败），该状态表示该笔退款已失败，并且不可重试，后续如果要重新退款，需要更换退款请求号。
        /// </summary>
        [JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; }
    }
}
