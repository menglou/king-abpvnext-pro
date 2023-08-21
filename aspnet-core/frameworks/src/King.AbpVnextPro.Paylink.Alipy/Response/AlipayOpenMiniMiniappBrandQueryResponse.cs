﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappBrandQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappBrandQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户已有品牌
        /// </summary>
        [JsonPropertyName("merchant_brand_list_result")]
        public MerchantBrandListResult MerchantBrandListResult { get; set; }

        /// <summary>
        /// 小程序品牌认证结果
        /// </summary>
        [JsonPropertyName("miniapp_brand_audit_result")]
        public MiniappBrandAuditResult MiniappBrandAuditResult { get; set; }
    }
}
