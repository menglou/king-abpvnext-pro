﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicAuthGettokenResponse.
    /// </summary>
    public class AlipayMobilePublicAuthGettokenResponse : AlipayResponse
    {
        /// <summary>
        /// 返回码。处理成功：200；处理失败：请参考返回码。
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 支付宝返回的处理结果说明，请参考返回码
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }

        /// <summary>
        /// 跳转到授权页面需要的Token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
