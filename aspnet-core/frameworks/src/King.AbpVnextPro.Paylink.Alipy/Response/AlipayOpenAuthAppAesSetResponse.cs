﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthAppAesSetResponse.
    /// </summary>
    public class AlipayOpenAuthAppAesSetResponse : AlipayResponse
    {
        /// <summary>
        /// 商家应用AES KEY密文，需要ISV使用三方应用配置的AES密钥内容进行解密。详情参见 <a href="https://opendocs.alipay.com/isv/grefvl/getaes">应用AES密钥管理</a>。
        /// </summary>
        [JsonPropertyName("aes_key")]
        public string AesKey { get; set; }
    }
}
