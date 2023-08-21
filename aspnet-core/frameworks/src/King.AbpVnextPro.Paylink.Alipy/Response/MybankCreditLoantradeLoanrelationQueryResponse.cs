﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanrelationQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否有融资关系的标志
        /// </summary>
        [JsonPropertyName("loan_relation_flag")]
        public bool LoanRelationFlag { get; set; }
    }
}
