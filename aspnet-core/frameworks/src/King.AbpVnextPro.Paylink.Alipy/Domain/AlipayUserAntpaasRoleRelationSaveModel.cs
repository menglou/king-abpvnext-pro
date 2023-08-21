﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAntpaasRoleRelationSaveModel Data Structure.
    /// </summary>
    public class AlipayUserAntpaasRoleRelationSaveModel : AlipayObject
    {
        /// <summary>
        /// 需要绑定的支付宝用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// true/false，若支付宝用户已被同一userSource下其他外部用户绑定，则自动删除已有关系，仅在opType=enable时有效
        /// </summary>
        [JsonPropertyName("alipay_user_occupied_auto_delete")]
        public bool AlipayUserOccupiedAutoDelete { get; set; }

        /// <summary>
        /// 可为enable/delete, 表示存储/删除绑定关系
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 外部用户id唯一标识, 例如高德用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// true/false, 默认false, 若用户已被其它支付宝用户绑定，则自动删除已有关系, 仅在opType=enable时有效
        /// </summary>
        [JsonPropertyName("user_occupied_auto_delete")]
        public bool UserOccupiedAutoDelete { get; set; }

        /// <summary>
        /// 用户来源, 接入时会分配给接入方
        /// </summary>
        [JsonPropertyName("user_source")]
        public string UserSource { get; set; }
    }
}
