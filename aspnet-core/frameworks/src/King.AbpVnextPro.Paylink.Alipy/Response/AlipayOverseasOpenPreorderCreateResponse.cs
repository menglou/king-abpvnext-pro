﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasOpenPreorderCreateResponse.
    /// </summary>
    public class AlipayOverseasOpenPreorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 预创建单单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 预订单链接地址（小程序的链接地址）
        /// </summary>
        [JsonPropertyName("pre_order_link")]
        public string PreOrderLink { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }
    }
}
