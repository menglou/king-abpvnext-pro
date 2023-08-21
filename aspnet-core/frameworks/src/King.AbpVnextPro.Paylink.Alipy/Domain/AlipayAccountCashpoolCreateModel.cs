﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolCreateModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolCreateModel : AlipayObject
    {
        /// <summary>
        /// 设置资金池名称
        /// </summary>
        [JsonPropertyName("cash_pool_name")]
        public string CashPoolName { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，初始、运行、暂停状态
        /// </summary>
        [JsonPropertyName("cash_pool_status")]
        public string CashPoolStatus { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 提交人名称
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
