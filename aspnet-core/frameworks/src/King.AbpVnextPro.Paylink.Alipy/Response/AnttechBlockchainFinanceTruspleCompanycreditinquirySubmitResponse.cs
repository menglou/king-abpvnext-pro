﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleCompanycreditinquirySubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTruspleCompanycreditinquirySubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 结果状态，S表示成功，F表示明确失败，U表示未知异常。一般返回U，调用方可能会重试
        /// </summary>
        [JsonPropertyName("result_status")]
        public string ResultStatus { get; set; }
    }
}
