﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneCouponReceiveResponse.
    /// </summary>
    public class AlipayInsSceneCouponReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 保单凭证号;商户生成的外部投保业务号不传时则必传
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 保险产品
        /// </summary>
        [JsonPropertyName("product")]
        public InsProduct Product { get; set; }
    }
}
