﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SchemaVO Data Structure.
    /// </summary>
    public class SchemaVO : AlipayObject
    {
        /// <summary>
        /// 风险日利率
        /// </summary>
        [JsonPropertyName("daily_risk_int_rate")]
        public string DailyRiskIntRate { get; set; }

        /// <summary>
        /// 最大申请金额
        /// </summary>
        [JsonPropertyName("max_apply_amt")]
        public string MaxApplyAmt { get; set; }

        /// <summary>
        /// 最小申请金额
        /// </summary>
        [JsonPropertyName("min_apply_amt")]
        public string MinApplyAmt { get; set; }

        /// <summary>
        /// 支持的还款方式列表，取值{1, 3, 6}：1-等额本息; 3-按期付息到期还本;  6-到期一次性还本付息;
        /// </summary>
        [JsonPropertyName("repay_mode_list")]
        public List<string> RepayModeList { get; set; }

        /// <summary>
        /// 支持的还款期限列表
        /// </summary>
        [JsonPropertyName("term_list")]
        public List<LoanTerm> TermList { get; set; }
    }
}
