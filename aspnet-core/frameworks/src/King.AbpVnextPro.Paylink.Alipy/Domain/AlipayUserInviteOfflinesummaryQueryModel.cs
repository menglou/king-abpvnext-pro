﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryModel Data Structure.
    /// </summary>
    public class AlipayUserInviteOfflinesummaryQueryModel : AlipayObject
    {
        /// <summary>
        /// 二级渠道
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 参数名task_id，提供给商户按不同的线下拉新任务类型查询任务完成报表，当前枚举值有：xianxia001,xianxia002,xianxia_super,xianxia_bank。获取方式：该API仅提供给KA商户使用，接入时由运营沟通该参数如何使用。
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
