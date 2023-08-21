﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// WhitehatInfo Data Structure.
    /// </summary>
    public class WhitehatInfo : AlipayObject
    {
        /// <summary>
        /// 当前有效的安全币奖励
        /// </summary>
        [JsonPropertyName("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 历史总金币奖励
        /// </summary>
        [JsonPropertyName("history_coin")]
        public long HistoryCoin { get; set; }

        /// <summary>
        /// 称号
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }
    }
}
