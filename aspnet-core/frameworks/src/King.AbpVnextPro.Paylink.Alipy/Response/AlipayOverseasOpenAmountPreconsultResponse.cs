﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasOpenAmountPreconsultResponse.
    /// </summary>
    public class AlipayOverseasOpenAmountPreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 缴费金额信息
        /// </summary>
        [JsonPropertyName("amount_info")]
        public TuitionISVAmountInfoDTO AmountInfo { get; set; }

        /// <summary>
        /// 外部参考号
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// 金额试算结果
        /// </summary>
        [JsonPropertyName("result")]
        public TuitionISVResult Result { get; set; }
    }
}
