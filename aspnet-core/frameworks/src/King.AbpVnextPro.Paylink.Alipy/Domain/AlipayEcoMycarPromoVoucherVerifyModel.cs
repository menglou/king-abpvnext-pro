﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarPromoVoucherVerifyModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarPromoVoucherVerifyModel : AlipayObject
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态 1. 待支付 4. 交易关闭 6. 待发货 53. 已评价 55. 已核销 56. 交易完成
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonPropertyName("sms_code")]
        public string SmsCode { get; set; }
    }
}
