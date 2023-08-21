﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUserQueryResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 菜单唯一标识
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// 结果码描述
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
