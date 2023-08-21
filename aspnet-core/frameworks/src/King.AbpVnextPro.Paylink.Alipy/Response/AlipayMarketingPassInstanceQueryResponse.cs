﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingPassInstanceQueryResponse.
    /// </summary>
    public class AlipayMarketingPassInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 卡券实例列表
        /// </summary>
        [JsonPropertyName("instance_list")]
        public List<PassInstanceDetail> InstanceList { get; set; }

        /// <summary>
        /// 当前查询的页码，页码从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前查询的每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 卡券实例总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }

        /// <summary>
        /// 按page_size分页的总页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }
    }
}
