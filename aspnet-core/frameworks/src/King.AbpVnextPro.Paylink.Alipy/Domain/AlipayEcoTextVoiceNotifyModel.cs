﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoTextVoiceNotifyModel Data Structure.
    /// </summary>
    public class AlipayEcoTextVoiceNotifyModel : AlipayObject
    {
        /// <summary>
        /// 语音回调列表
        /// </summary>
        [JsonPropertyName("callbacks")]
        public List<SpiVoiceCallback> Callbacks { get; set; }
    }
}
