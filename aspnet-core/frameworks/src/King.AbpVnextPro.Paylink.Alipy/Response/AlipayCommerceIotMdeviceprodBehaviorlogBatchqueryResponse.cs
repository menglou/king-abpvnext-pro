﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodBehaviorlogBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 日志关联的设备信息
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<DeviceBehaviorLogResponse> ResultList { get; set; }
    }
}
