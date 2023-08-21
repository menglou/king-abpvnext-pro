﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditLoantradeNewloanarRepayApplyResponse.
    /// </summary>
    public class MybankCreditLoantradeNewloanarRepayApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 受理事件编号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }
    }
}
