﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// GoodsDetailIstd Data Structure.
    /// </summary>
    public class GoodsDetailIstd : AlipayObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
