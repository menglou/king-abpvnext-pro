﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InstAccountInfo Data Structure.
    /// </summary>
    public class InstAccountInfo : AlipayObject
    {
        /// <summary>
        /// 机构二类户账户号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 工单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 账户工单状态
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }
    }
}
