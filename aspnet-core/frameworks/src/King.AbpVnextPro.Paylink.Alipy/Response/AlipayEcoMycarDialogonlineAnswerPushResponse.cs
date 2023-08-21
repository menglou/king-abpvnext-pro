﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarDialogonlineAnswerPushResponse.
    /// </summary>
    public class AlipayEcoMycarDialogonlineAnswerPushResponse : AlipayResponse
    {
        /// <summary>
        /// 技师ID，支付宝对技师的唯一标识
        /// </summary>
        [JsonPropertyName("answer_id")]
        public string AnswerId { get; set; }
    }
}
