﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertSubjectResponse Data Structure.
    /// </summary>
    public class KbAdvertSubjectResponse : AlipayObject
    {
        /// <summary>
        /// 分佣规则
        /// </summary>
        [JsonPropertyName("commission_clause")]
        public KbAdvertCommissionClauseResponse CommissionClause { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券标的  只有type=voucher才会有值
        /// </summary>
        [JsonPropertyName("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
