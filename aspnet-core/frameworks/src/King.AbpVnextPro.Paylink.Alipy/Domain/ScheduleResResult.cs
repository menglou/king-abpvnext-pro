﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ScheduleResResult Data Structure.
    /// </summary>
    public class ScheduleResResult : AlipayObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("data")]
        public ScheduleResItem Data { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
