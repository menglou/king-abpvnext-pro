﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveKgopenQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveKgopenQueryModel : AlipayObject
    {
        /// <summary>
        /// 所属在线服务的编码
        /// </summary>
        [JsonPropertyName("online_service_code")]
        public string OnlineServiceCode { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [JsonPropertyName("params")]
        public List<MapParameter> Params { get; set; }
    }
}
