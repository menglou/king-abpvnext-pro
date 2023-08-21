﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// IotDevicePersonalInfo Data Structure.
    /// </summary>
    public class IotDevicePersonalInfo : AlipayObject
    {
        /// <summary>
        /// 协议服务商用于唯一标识该设备的设备id(协议服务商定义)
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
