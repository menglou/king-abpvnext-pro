﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserDetail Data Structure.
    /// </summary>
    public class AlipayUserDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否通过实名认证
        /// </summary>
        [JsonPropertyName("certified")]
        public bool Certified { get; set; }

        /// <summary>
        /// 支付宝登录号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 性别。可选值:m(男),f(女)
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 用户状态。可选:normal(正常), supervise (监管),delete(注销)
        /// </summary>
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户类型。可选：personal（个人），company（公司）
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
