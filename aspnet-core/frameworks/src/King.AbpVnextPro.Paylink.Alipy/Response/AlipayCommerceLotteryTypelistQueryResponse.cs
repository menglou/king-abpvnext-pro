﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceLotteryTypelistQueryResponse.
    /// </summary>
    public class AlipayCommerceLotteryTypelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 彩票系统支持的可用于赠送的彩种类型列表
        /// </summary>
        [JsonPropertyName("results")]
        public List<LotteryType> Results { get; set; }

        /// <summary>
        /// 彩票系统支持的可用于赠送的彩种个数
        /// </summary>
        [JsonPropertyName("total_result")]
        public long TotalResult { get; set; }
    }
}
