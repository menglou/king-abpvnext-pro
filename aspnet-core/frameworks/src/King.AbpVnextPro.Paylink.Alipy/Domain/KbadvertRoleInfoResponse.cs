﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbadvertRoleInfoResponse Data Structure.
    /// </summary>
    public class KbadvertRoleInfoResponse : AlipayObject
    {
        /// <summary>
        /// 角色code
        /// </summary>
        [JsonPropertyName("role_code")]
        public string RoleCode { get; set; }

        /// <summary>
        /// NOT_OPEN:未开通  OPENED:已经开通
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
