﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicQrcodeCreateResponse.
    /// </summary>
    public class AlipayOpenPublicQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码图片地址，可跳转到实际图片
        /// </summary>
        [JsonPropertyName("code_img")]
        public string CodeImg { get; set; }

        /// <summary>
        /// 二维码有效时间，单位（秒）。永久码暂时忽略该信息
        /// </summary>
        [JsonPropertyName("expire_second")]
        public string ExpireSecond { get; set; }
    }
}
