﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ConversionData Data Structure.
    /// </summary>
    public class ConversionData : AlipayObject
    {
        /// <summary>
        /// 留资流水号，用于source=XLIGHT
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 转化金额，单位分
        /// </summary>
        [JsonPropertyName("conversion_amount")]
        public string ConversionAmount { get; set; }

        /// <summary>
        /// 转化事件ID
        /// </summary>
        [JsonPropertyName("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化时间，UTC 时间戳，单位：秒
        /// </summary>
        [JsonPropertyName("conversion_time")]
        public long ConversionTime { get; set; }

        /// <summary>
        /// 转化事件类型
        /// </summary>
        [JsonPropertyName("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 创意ID
        /// </summary>
        [JsonPropertyName("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 数据集id
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 商户在灯火pb端的id, 可代替principal_tag
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商家标志
        /// </summary>
        [JsonPropertyName("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 留资数据列表，用于source=OTHER
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<ConversionProperty> PropertyList { get; set; }

        /// <summary>
        /// 留资来源：XLIGHT-灯火留资；OTHER-其它
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 转化用户唯一标识
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// PID : 2088pid PHONE : 手机号
        /// </summary>
        [JsonPropertyName("uuid_type")]
        public string UuidType { get; set; }
    }
}
