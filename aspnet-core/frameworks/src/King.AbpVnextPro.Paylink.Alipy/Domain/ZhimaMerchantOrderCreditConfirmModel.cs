﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditConfirmModel Data Structure.
    /// </summary>
    public class ZhimaMerchantOrderCreditConfirmModel : AlipayObject
    {
        /// <summary>
        /// 商户订单号，必需参数，用于确认芝麻订单，该参数必须与调用接口（zhima.merchant.order.credit.create）时传入的out_order_no一致
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 芝麻订单号，必需参数，用于确认芝麻订单，通过调用接口（zhima.merchant.order.credit.create）后获取
        /// </summary>
        [JsonPropertyName("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
