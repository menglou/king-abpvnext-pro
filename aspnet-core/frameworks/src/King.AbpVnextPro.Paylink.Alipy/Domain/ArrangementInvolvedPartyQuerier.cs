﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ArrangementInvolvedPartyQuerier Data Structure.
    /// </summary>
    public class ArrangementInvolvedPartyQuerier : AlipayObject
    {
        /// <summary>
        /// 参与者id
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 用户uid/参与者角色id
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 参与者角色类型，为空时表示所有类型都查询.  可选值：01 甲方 11 乙方 21丙方
        /// </summary>
        [JsonPropertyName("ip_type")]
        public string IpType { get; set; }
    }
}
