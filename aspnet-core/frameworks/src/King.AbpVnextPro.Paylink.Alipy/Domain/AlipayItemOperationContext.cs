﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayItemOperationContext Data Structure.
    /// </summary>
    public class AlipayItemOperationContext : AlipayObject
    {
        /// <summary>
        /// 商品创建者，商户授权模式此值不需要填写。
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 操作角色类型，授权授权模式下此值不需要填写。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 商户ID，如果商户传入此值，将以此商户ID作为业务主体，商户授权模式此值不需要填写。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
