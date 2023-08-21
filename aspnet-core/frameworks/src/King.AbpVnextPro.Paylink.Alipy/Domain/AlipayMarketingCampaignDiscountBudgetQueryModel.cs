﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountBudgetQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountBudgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 预算名称
        /// </summary>
        [JsonPropertyName("budget_id")]
        public string BudgetId { get; set; }
    }
}
