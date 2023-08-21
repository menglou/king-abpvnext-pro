﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetBbaremainamountQueryResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetBbaremainamountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// BBA可用、剩余金额
        /// </summary>
        [JsonPropertyName("result_data")]
        public BizBudgetApplyAmountDTO ResultData { get; set; }

        /// <summary>
        /// 错误的详细信息，用于具体描述错误信息
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
