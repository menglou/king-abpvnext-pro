﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageMatcherSendResponse.
    /// </summary>
    public class AlipayMobilePublicMessageMatcherSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 对应toUserId，标准Alipay UserId
        /// </summary>
        [JsonPropertyName("to_alipay_user_id")]
        public string ToAlipayUserId { get; set; }

        /// <summary>
        /// 消息接收人的用户ID，值取的openId
        /// </summary>
        [JsonPropertyName("to_user_id")]
        public string ToUserId { get; set; }
    }
}
