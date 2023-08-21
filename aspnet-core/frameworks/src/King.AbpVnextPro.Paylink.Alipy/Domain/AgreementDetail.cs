﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AgreementDetail Data Structure.
    /// </summary>
    public class AgreementDetail : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
