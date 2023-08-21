﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleCreateResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRoleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 新增返回角色roleId,修改则返回修改的roleId.
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
