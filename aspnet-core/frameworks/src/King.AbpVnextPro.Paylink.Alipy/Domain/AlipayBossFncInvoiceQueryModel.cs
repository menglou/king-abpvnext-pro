﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncInvoiceQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncInvoiceQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询ID：用于标示一张发票，通过发票综合查询可以查询到该ID。
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }
    }
}
