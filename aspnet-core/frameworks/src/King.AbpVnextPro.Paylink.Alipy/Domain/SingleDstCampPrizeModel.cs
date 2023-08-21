﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SingleDstCampPrizeModel Data Structure.
    /// </summary>
    public class SingleDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 预算id
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 奖品id,新增不传，修改传
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 折扣幅度只能填写数字，大于0，小数点后最多2位，整数部分不能超过8位
        /// </summary>
        [JsonPropertyName("reduce_amt")]
        public string ReduceAmt { get; set; }
    }
}
