﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntfortuneYebInfoAdvertisingQueryResponse.
    /// </summary>
    public class AntfortuneYebInfoAdvertisingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// advertising_type：广告投放类型。  目前值为00或01。  00:表示进行投放。  01:表示不进行投放。
        /// </summary>
        [JsonPropertyName("advertising_type")]
        public string AdvertisingType { get; set; }
    }
}
