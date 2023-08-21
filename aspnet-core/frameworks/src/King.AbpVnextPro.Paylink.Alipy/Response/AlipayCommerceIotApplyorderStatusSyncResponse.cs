﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncResponse.
    /// </summary>
    public class AlipayCommerceIotApplyorderStatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 该订单下关联的设备数量
        /// </summary>
        [JsonPropertyName("device_amount")]
        public long DeviceAmount { get; set; }
    }
}
