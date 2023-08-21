﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayExscUserCurrentsignGetResponse.
    /// </summary>
    public class AlipayExscUserCurrentsignGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果的业务类型。当前签约绑卡业务类型 （current_sign）
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务处理结果   true 无资金流入记录，本次是首次交易   false 已有资金流入记录，本次不是首次交易
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
