﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppRechargeTradeDetectResponse.
    /// </summary>
    public class AlipayEbppRechargeTradeDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 手机号绑定的userId是否有充值记录。
        /// </summary>
        [JsonPropertyName("check_result")]
        public bool CheckResult { get; set; }
    }
}
