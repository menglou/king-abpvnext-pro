﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillOrderCloseModel Data Structure.
    /// </summary>
    public class AlipayTradeRepaybillOrderCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 还款的外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
