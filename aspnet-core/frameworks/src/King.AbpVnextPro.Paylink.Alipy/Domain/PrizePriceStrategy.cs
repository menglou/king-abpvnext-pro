﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PrizePriceStrategy Data Structure.
    /// </summary>
    public class PrizePriceStrategy : AlipayObject
    {
        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonPropertyName("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonPropertyName("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 废弃-不再使用
        /// </summary>
        [JsonPropertyName("stragety_value")]
        public string StragetyValue { get; set; }

        /// <summary>
        /// RANDOM_PRICE随机，FIX_PRICE定额奖品，不同的定价策略填写不同值，具体根据业务评估
        /// </summary>
        [JsonPropertyName("strategy_type")]
        public string StrategyType { get; set; }

        /// <summary>
        /// 定价策略值，根据不同的奖品类型填写不同的值，具体用法联系营销技术获取
        /// </summary>
        [JsonPropertyName("strategy_value")]
        public string StrategyValue { get; set; }
    }
}
