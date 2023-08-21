﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MsgSendErrorData Data Structure.
    /// </summary>
    public class MsgSendErrorData : AlipayObject
    {
        /// <summary>
        /// 错误吗
        /// </summary>
        [JsonPropertyName("error_code")]
        public long ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 登录id
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }
    }
}
