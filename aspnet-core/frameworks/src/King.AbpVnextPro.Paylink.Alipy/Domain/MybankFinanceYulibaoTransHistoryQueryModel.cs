﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoTransHistoryQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoTransHistoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询交易的结束时间，必须是格式为 yyyyMMdd 的日期字符串，且日期要大于等于start_date，时间最大跨度为30天，如start_date 为20200808，则end_date最大值为20200906。
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 基金代码。余利宝场景固定为 001529。
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 页码，历史交易记录分页展示的页码。必须为正整数，最大值为99。
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页条数，历史交易记录查询时每页的最大条数。必须为正整数，最大值为50。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询交易的开始时间，必须是格式为yyyyMMdd的日期字符串，如20200808。
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
