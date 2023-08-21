﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// Condition Data Structure.
    /// </summary>
    public class Condition : AlipayObject
    {
        /// <summary>
        /// 字段名称，目前支持以下字段：  name: 活动名称   startTime: 开始时间  endTime: 结束时间  status：活动状态
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 对应于field_name的字段值，当field_name为status时，field_value支持STARTED、STARTING、MODIFYING、CLOSED、CLOSING、DISABLED几种值，用|分隔，代表查询这些状态中的活动，此时operator只能为IN,field_name为name时候value表示要查询的活动名，field_name为时间时,field_value为开始或结束时间，格式如2016-10-01 00:00:00
        /// </summary>
        [JsonPropertyName("field_value")]
        public string FieldValue { get; set; }

        /// <summary>
        /// 操作符,EQUAL:等于,IN:范围。目前支持field_name=status且operator=IN,多个状态以"|"分隔
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
