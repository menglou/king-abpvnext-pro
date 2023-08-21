﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlansQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePlansQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 到账明细列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<InstalmentPlanDetailTuitionDTO> Data { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
