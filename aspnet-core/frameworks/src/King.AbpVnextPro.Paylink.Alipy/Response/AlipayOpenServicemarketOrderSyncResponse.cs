﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenServicemarketOrderSyncResponse.
    /// </summary>
    public class AlipayOpenServicemarketOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 服务市场订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
