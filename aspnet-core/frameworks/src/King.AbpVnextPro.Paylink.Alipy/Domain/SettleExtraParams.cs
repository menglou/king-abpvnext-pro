﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SettleExtraParams Data Structure.
    /// </summary>
    public class SettleExtraParams : AlipayObject
    {
        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        [JsonPropertyName("quit_type")]
        public string QuitType { get; set; }
    }
}
