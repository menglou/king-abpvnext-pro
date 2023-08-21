﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单的申请单id，applyid
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
