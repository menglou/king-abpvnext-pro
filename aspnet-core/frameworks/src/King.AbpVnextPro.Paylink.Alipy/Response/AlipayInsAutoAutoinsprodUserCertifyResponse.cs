﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodUserCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 验证结果
        /// </summary>
        [JsonPropertyName("agent_cert_result")]
        public string AgentCertResult { get; set; }
    }
}
