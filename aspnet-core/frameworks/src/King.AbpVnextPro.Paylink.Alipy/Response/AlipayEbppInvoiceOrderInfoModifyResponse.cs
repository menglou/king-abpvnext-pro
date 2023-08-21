﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceOrderInfoModifyResponse.
    /// </summary>
    public class AlipayEbppInvoiceOrderInfoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 明细返回码
        /// </summary>
        [JsonPropertyName("sub_code")]
        public new string SubCode { get; set; }

        /// <summary>
        /// 明细返回码描述
        /// </summary>
        [JsonPropertyName("sub_msg")]
        public new string SubMsg { get; set; }
    }
}
