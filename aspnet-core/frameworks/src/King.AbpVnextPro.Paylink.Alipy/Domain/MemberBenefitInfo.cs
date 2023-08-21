﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MemberBenefitInfo Data Structure.
    /// </summary>
    public class MemberBenefitInfo : AlipayObject
    {
        /// <summary>
        /// 权益对应跳转地址
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 权益图标地址
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 会员权益标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 权益价值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
