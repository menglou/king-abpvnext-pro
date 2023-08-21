﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// OrderPageQueryDTO Data Structure.
    /// </summary>
    public class OrderPageQueryDTO : AlipayObject
    {
        /// <summary>
        /// 审核单数据信息
        /// </summary>
        [JsonPropertyName("page_data")]
        public List<ApplyOrderData> PageData { get; set; }

        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_number")]
        public long TotalNumber { get; set; }
    }
}
