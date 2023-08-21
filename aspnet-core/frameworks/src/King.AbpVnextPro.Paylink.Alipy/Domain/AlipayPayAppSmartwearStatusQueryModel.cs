﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPayAppSmartwearStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayPayAppSmartwearStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("device_model")]
        public string DeviceModel { get; set; }
    }
}
