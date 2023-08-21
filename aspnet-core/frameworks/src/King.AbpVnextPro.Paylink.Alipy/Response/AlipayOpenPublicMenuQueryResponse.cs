﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuQueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 一级菜单数组，个数应为1~4个
        /// </summary>
        [JsonPropertyName("menu_content")]
        public string MenuContent { get; set; }
    }
}
