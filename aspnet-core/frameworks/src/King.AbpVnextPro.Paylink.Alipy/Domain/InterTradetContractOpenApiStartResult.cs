﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InterTradetContractOpenApiStartResult Data Structure.
    /// </summary>
    public class InterTradetContractOpenApiStartResult : AlipayObject
    {
        /// <summary>
        /// 合约审批地址
        /// </summary>
        [JsonPropertyName("contract_workflow_urls")]
        public List<ContractWorkflowUrlResult> ContractWorkflowUrls { get; set; }
    }
}
