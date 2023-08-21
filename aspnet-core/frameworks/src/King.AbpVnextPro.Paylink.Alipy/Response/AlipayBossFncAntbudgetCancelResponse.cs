﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetCancelResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 描述具体的错误信息，方便排查问题
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
