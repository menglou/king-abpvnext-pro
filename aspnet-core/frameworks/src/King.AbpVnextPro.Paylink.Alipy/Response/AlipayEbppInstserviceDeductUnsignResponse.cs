﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductUnsignResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 流程id
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }
    }
}
