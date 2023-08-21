﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessPaymenthubCloseModel Data Structure.
    /// </summary>
    public class AlipayBusinessPaymenthubCloseModel : AlipayObject
    {
        /// <summary>
        /// 支付id，支付宝针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }
    }
}
