﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceabilityIdentifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceabilityIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 能力接口返回值
        /// </summary>
        [JsonPropertyName("biz_info")]
        public FaceAbilityExtInfo BizInfo { get; set; }
    }
}
