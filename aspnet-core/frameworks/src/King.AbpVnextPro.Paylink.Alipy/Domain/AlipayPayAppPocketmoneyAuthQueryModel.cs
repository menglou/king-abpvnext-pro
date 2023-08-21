﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthQueryModel Data Structure.
    /// </summary>
    public class AlipayPayAppPocketmoneyAuthQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 厂商家长ID
        /// </summary>
        [JsonPropertyName("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
