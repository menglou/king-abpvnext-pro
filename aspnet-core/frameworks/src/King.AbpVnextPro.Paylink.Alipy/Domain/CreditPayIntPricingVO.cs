﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CreditPayIntPricingVO Data Structure.
    /// </summary>
    public class CreditPayIntPricingVO : AlipayObject
    {
        /// <summary>
        /// 实际日利率，百分比形式
        /// </summary>
        [JsonPropertyName("actual_day_int_rate")]
        public string ActualDayIntRate { get; set; }

        /// <summary>
        /// 实际利息，单位元
        /// </summary>
        [JsonPropertyName("actual_int")]
        public string ActualInt { get; set; }

        /// <summary>
        /// 实际利率，小数形式
        /// </summary>
        [JsonPropertyName("actual_int_rate")]
        public string ActualIntRate { get; set; }

        /// <summary>
        /// 分段利率
        /// </summary>
        [JsonPropertyName("day_range_pricing_list")]
        public List<CreditPayDayRangePricingVO> DayRangePricingList { get; set; }

        /// <summary>
        /// 原始日利率，百分比形式
        /// </summary>
        [JsonPropertyName("origin_day_int_rate")]
        public string OriginDayIntRate { get; set; }

        /// <summary>
        /// 原始利息，单位元
        /// </summary>
        [JsonPropertyName("origin_int")]
        public string OriginInt { get; set; }

        /// <summary>
        /// 原始利率，小数形式
        /// </summary>
        [JsonPropertyName("origin_int_rate")]
        public string OriginIntRate { get; set; }
    }
}
