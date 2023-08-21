﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantRole Data Structure.
    /// </summary>
    public class KoubeiMerchantRole : AlipayObject
    {
        /// <summary>
        /// 员工数量
        /// </summary>
        [JsonPropertyName("operator_num")]
        public string OperatorNum { get; set; }

        /// <summary>
        /// 权限数量
        /// </summary>
        [JsonPropertyName("permission_num")]
        public string PermissionNum { get; set; }

        /// <summary>
        /// 角色标识码，如财务
        /// </summary>
        [JsonPropertyName("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }
    }
}
