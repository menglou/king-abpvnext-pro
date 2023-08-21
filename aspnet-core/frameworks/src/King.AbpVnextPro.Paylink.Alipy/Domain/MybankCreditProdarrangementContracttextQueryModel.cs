﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryModel Data Structure.
    /// </summary>
    public class MybankCreditProdarrangementContracttextQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务编号，例如合约编号，贷款申请编号等
        /// </summary>
        [JsonPropertyName("bsn_no")]
        public string BsnNo { get; set; }

        /// <summary>
        /// 合同类型，枚举如下：LOAN：贷款合同类型，PRE_LOAN_INVESTIGATION : 贷前调查征信授权合同， POST_LOAN_MANAGEMENT : 贷后管理征信授权合同;
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        /// 查询场景类型，例如根据业务单据号或者合约号来查询；  枚举如下：AR_NO：合约类型，BSN_NO：业务场景
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }
    }
}
