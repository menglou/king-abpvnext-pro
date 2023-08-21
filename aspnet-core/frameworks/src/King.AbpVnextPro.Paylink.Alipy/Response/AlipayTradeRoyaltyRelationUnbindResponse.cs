﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationUnbindResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRelationUnbindResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果码。SUCCESS：分账关系解绑成功； FAIL：分账关系解绑失败。
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
