﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SignResultValue Data Structure.
    /// </summary>
    public class SignResultValue : AlipayObject
    {
        /// <summary>
        /// 已生效的销账/出账机构
        /// </summary>
        [JsonPropertyName("effect_biz_value")]
        public string EffectBizValue { get; set; }
    }
}
