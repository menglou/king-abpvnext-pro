﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PaginationCook Data Structure.
    /// </summary>
    public class PaginationCook : AlipayObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<KbdishCookInfo> List { get; set; }

        /// <summary>
        /// 表示当前页数
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public string TotalPage { get; set; }
    }
}
