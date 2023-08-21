﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ReplyRecordResponse Data Structure.
    /// </summary>
    public class ReplyRecordResponse : AlipayObject
    {
        /// <summary>
        /// 回复内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 回复图片
        /// </summary>
        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 回复人名称
        /// </summary>
        [JsonPropertyName("replier_name")]
        public string ReplierName { get; set; }

        /// <summary>
        /// 用户：USER  商家：MERCHANT 系统：SYSTEM 审核小二：AUDITOR 政府单位：GOVERNMENT
        /// </summary>
        [JsonPropertyName("replier_role")]
        public string ReplierRole { get; set; }
    }
}
