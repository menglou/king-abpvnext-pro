﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsMktObjectDTO Data Structure.
    /// </summary>
    public class InsMktObjectDTO : AlipayObject
    {
        /// <summary>
        /// 活动标的id
        /// </summary>
        [JsonPropertyName("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
