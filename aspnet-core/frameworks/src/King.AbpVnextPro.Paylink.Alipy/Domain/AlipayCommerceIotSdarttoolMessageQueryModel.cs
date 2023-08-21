﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageQueryModel : AlipayObject
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonPropertyName("message_no")]
        public string MessageNo { get; set; }
    }
}
