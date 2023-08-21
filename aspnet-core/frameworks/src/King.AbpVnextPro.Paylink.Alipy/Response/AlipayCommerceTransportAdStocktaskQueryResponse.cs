﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存任务执行情况
        /// </summary>
        [JsonPropertyName("stock_task")]
        public StockTask StockTask { get; set; }
    }
}
