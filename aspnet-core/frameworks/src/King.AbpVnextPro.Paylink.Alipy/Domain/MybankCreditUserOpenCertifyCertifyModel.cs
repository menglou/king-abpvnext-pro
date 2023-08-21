﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditUserOpenCertifyCertifyModel Data Structure.
    /// </summary>
    public class MybankCreditUserOpenCertifyCertifyModel : AlipayObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，由开放认证初始化接口调用后生成，后续的操作都需要用到
        /// </summary>
        [JsonPropertyName("certify_id")]
        public string CertifyId { get; set; }
    }
}
