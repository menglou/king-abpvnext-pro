﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPaiProxyRedirectResponse.
    /// </summary>
    public class AlipayPaiProxyRedirectResponse : AlipayResponse
    {
        /// <summary>
        /// 测试返回数据，页面级接口此项没用
        /// </summary>
        [JsonPropertyName("test_res")]
        public string TestRes { get; set; }
    }
}
