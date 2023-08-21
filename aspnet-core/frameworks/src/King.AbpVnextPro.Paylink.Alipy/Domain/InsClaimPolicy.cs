﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsClaimPolicy Data Structure.
    /// </summary>
    public class InsClaimPolicy : AlipayObject
    {
        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
