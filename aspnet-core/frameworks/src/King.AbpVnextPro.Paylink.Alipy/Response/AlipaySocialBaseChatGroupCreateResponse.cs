﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGroupCreateResponse.
    /// </summary>
    public class AlipaySocialBaseChatGroupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 群信息
        /// </summary>
        [JsonPropertyName("group_info")]
        public GroupInfo GroupInfo { get; set; }

        /// <summary>
        /// 群成员信息列表
        /// </summary>
        [JsonPropertyName("member_infos")]
        public List<MemberInfo> MemberInfos { get; set; }
    }
}
