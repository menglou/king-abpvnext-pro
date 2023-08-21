﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenPreorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 预缴费单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
