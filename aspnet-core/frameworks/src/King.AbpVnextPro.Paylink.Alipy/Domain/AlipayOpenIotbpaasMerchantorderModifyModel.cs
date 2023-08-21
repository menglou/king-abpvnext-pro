﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderModifyModel : AlipayObject
    {
        /// <summary>
        /// 设备订单状态列表
        /// </summary>
        [JsonPropertyName("device_order_status_list")]
        public List<DeviceOrderStatus> DeviceOrderStatusList { get; set; }
    }
}
