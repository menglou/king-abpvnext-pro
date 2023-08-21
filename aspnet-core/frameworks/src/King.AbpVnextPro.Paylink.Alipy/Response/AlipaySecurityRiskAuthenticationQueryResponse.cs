﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 身份安全业务相关查询业务信息
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }
    }
}
