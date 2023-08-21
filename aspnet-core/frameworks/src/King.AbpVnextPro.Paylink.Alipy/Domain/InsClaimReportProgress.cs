﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsClaimReportProgress Data Structure.
    /// </summary>
    public class InsClaimReportProgress : AlipayObject
    {
        /// <summary>
        /// 案件更新内容
        /// </summary>
        [JsonPropertyName("progress_update_content")]
        public string ProgressUpdateContent { get; set; }

        /// <summary>
        /// 案件更新进度时间
        /// </summary>
        [JsonPropertyName("progress_update_time")]
        public string ProgressUpdateTime { get; set; }

        /// <summary>
        /// 进度状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
