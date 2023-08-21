﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditLoantradePayOrderQueryResponse.
    /// </summary>
    public class MybankCreditLoantradePayOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 系统异常
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询接口列表
        /// </summary>
        [JsonPropertyName("query_result")]
        public List<CreditPayOrderQueryVO> QueryResult { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
