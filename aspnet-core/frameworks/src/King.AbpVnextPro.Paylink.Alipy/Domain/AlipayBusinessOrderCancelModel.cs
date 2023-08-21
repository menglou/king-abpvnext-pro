﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessOrderCancelModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderCancelModel : AlipayObject
    {
        /// <summary>
        /// 支付工具撤销请求明细。若该字段为空则认为是整单撤销
        /// </summary>
        [JsonPropertyName("cancel_paytool_list")]
        public List<PaytoolCancelRequestDetail> CancelPaytoolList { get; set; }

        /// <summary>
        /// 商户外部订单号，与支付宝订单号不能同时为空。注：商户已获取order_no（支付宝订单号）的情况下必须优先传入order_no
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号，与商户外部订单号不能同时为空。注：商户已获取order_no的情况下必须优先传入order_no
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
