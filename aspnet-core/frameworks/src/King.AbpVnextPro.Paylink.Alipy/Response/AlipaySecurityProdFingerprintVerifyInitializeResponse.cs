﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdFingerprintVerifyInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdFingerprintVerifyInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// ifaf_message:校验阶段服务端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含服务端的校验数据。
        /// </summary>
        [JsonPropertyName("server_response")]
        public string ServerResponse { get; set; }
    }
}
