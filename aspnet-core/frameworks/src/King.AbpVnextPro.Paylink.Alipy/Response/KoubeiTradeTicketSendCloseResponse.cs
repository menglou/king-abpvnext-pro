﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiTradeTicketSendCloseResponse.
    /// </summary>
    public class KoubeiTradeTicketSendCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）。
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
