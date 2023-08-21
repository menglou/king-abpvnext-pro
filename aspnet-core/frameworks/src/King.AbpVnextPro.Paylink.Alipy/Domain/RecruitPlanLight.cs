﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// RecruitPlanLight Data Structure.
    /// </summary>
    public class RecruitPlanLight : AlipayObject
    {
        /// <summary>
        /// 招商方案描述：富文本内容，可能包含html标签
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [JsonPropertyName("enroll_end_time")]
        public string EnrollEndTime { get; set; }

        /// <summary>
        /// 报名开始时间
        /// </summary>
        [JsonPropertyName("enroll_start_time")]
        public string EnrollStartTime { get; set; }

        /// <summary>
        /// 方案头图链接，150x150 以上尺寸的方形图片
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商方案名称
        /// </summary>
        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 方案状态: 可用:ENABLED
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
