﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ServiceTimeInfo Data Structure.
    /// </summary>
    public class ServiceTimeInfo : AlipayObject
    {
        /// <summary>
        /// 提前预约时间，单位分钟，大于0
        /// </summary>
        [JsonPropertyName("advance_time")]
        public long AdvanceTime { get; set; }

        /// <summary>
        /// 时间节点，精确到分，“-” 分隔符
        /// </summary>
        [JsonPropertyName("time_nodes")]
        public List<string> TimeNodes { get; set; }
    }
}
