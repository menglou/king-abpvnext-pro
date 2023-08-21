﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberDeleteModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotGroupMemberDeleteModel : AlipayObject
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [JsonPropertyName("sn_list")]
        public List<string> SnList { get; set; }
    }
}
