﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppIndustryKmsPubkeyQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryKmsPubkeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 使用调用方公钥加密过的用户公钥
        /// </summary>
        [JsonPropertyName("user_encrypt_pubkey")]
        public string UserEncryptPubkey { get; set; }
    }
}
