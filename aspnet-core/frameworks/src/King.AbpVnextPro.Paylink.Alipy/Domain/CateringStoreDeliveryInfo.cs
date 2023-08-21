﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CateringStoreDeliveryInfo Data Structure.
    /// </summary>
    public class CateringStoreDeliveryInfo : AlipayObject
    {
        /// <summary>
        /// 门店配送范围（单位：公里），数值型，精确至小数点两位。外卖场景必填，其余非必填。
        /// </summary>
        [JsonPropertyName("delivery_area")]
        public string DeliveryArea { get; set; }

        /// <summary>
        /// 配送费用。精确到小数点后1位。
        /// </summary>
        [JsonPropertyName("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 起送金额。精确到小数点后1位。外卖场景必填，其余非必填。
        /// </summary>
        [JsonPropertyName("delivery_threshold")]
        public string DeliveryThreshold { get; set; }
    }
}
