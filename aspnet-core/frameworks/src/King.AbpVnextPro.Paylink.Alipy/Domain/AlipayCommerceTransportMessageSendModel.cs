﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMessageSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportMessageSendModel : AlipayObject
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 商户业务时间。格式为"yyyy-MM-dd HH:mm:ss"。
        /// </summary>
        [JsonPropertyName("merchant_biz_time")]
        public string MerchantBizTime { get; set; }

        /// <summary>
        /// 消息通知数据。该字段格式请与支付宝技术人员沟通。
        /// </summary>
        [JsonPropertyName("notify_data")]
        public string NotifyData { get; set; }

        /// <summary>
        /// 消息发送时间。格式为"yyyy-MM-dd HH:mm:ss"。指定后，将会在这个指定时间点发送消息。不指定，则消息会立即发送。
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型，由支付宝配置提供。具体的通知类型请与支付宝技术人员沟通。
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 目标用户ID列表，最大支持50个。
        /// </summary>
        [JsonPropertyName("user_ids")]
        public List<string> UserIds { get; set; }
    }
}
