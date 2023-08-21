﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// StoreAddressInfo Data Structure.
    /// </summary>
    public class StoreAddressInfo : AlipayObject
    {
        /// <summary>
        /// 门店地址（格式：市/区/详细地址门牌号）
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 高德门店维度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 高德门店经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }
}
