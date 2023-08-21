﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetBbaremainamountQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncAntbudgetBbaremainamountQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务预算申请Code
        /// </summary>
        [JsonPropertyName("biz_budget_apply_code")]
        public string BizBudgetApplyCode { get; set; }
    }
}
