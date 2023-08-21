﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// HbMerchantBill Data Structure.
    /// </summary>
    public class HbMerchantBill : AlipayObject
    {
        /// <summary>
        /// 商家贴息金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 外部订单号，目前交易取不到，先留空
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [JsonPropertyName("period_num")]
        public string PeriodNum { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonPropertyName("trade_time")]
        public string TradeTime { get; set; }
    }
}
