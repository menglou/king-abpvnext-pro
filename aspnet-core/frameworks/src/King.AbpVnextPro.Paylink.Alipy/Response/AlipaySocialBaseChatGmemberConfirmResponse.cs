﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGmemberConfirmResponse.
    /// </summary>
    public class AlipaySocialBaseChatGmemberConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 所属的群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 是否在群中
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
