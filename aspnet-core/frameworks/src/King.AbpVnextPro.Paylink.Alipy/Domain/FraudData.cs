﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// FraudData Data Structure.
    /// </summary>
    public class FraudData : AlipayObject
    {
        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_identifier")]
        public string UserIdentifier { get; set; }
    }
}
