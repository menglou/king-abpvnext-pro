﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbIsvMaCode Data Structure.
    /// </summary>
    public class KbIsvMaCode : AlipayObject
    {
        /// <summary>
        /// 凭证码值
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 码的可核销份数
        /// </summary>
        [JsonPropertyName("num")]
        public string Num { get; set; }
    }
}
