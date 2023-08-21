﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiRpacrawlerQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiRpacrawlerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// RPA任务
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<RpaCrawlerTaskVO> TaskList { get; set; }

        /// <summary>
        /// 任务统计总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
