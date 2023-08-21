﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureInfoSendResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureInfoSendResponse : AlipayResponse
    {
        /// <summary>
        /// 返回更新失败的userId集合
        /// </summary>
        [JsonPropertyName("error_uids")]
        public string ErrorUids { get; set; }
    }
}
