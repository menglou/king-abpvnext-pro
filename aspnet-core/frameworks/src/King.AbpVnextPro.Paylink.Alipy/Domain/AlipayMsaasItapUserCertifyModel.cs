﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMsaasItapUserCertifyModel Data Structure.
    /// </summary>
    public class AlipayMsaasItapUserCertifyModel : AlipayObject
    {
        /// <summary>
        /// 用户认证消息体
        /// </summary>
        [JsonPropertyName("payload")]
        public List<UserCertifyPayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
