﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ContractWorkflowUrlResult Data Structure.
    /// </summary>
    public class ContractWorkflowUrlResult : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 审批地址
        /// </summary>
        [JsonPropertyName("workflow_url")]
        public string WorkflowUrl { get; set; }
    }
}
