﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundTransUniTransferResponse.
    /// </summary>
    public class AlipayFundTransUniTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        [JsonPropertyName("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 转账单据状态。 SUCCESS：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）； DEALING：处理中； REFUND：退票；
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("trans_date")]
        public string TransDate { get; set; }
    }
}
