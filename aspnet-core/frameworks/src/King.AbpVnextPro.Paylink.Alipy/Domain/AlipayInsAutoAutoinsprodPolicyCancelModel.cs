﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelModel : AlipayObject
    {
        /// <summary>
        /// 车险订单号
        /// </summary>
        [JsonPropertyName("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
