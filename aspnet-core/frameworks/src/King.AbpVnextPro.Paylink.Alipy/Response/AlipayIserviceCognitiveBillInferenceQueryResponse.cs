﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveBillInferenceQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveBillInferenceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票识别内容详细信息
        /// </summary>
        [JsonPropertyName("result")]
        public BillInferenceResult Result { get; set; }

        /// <summary>
        /// 信息抽取是否抽取成功
        /// </summary>
        [JsonPropertyName("ret")]
        public long Ret { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
