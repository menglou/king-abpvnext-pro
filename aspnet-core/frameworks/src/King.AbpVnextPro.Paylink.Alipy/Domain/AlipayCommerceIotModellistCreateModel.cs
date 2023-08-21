﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotModellistCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotModellistCreateModel : AlipayObject
    {
        /// <summary>
        /// 型号列表+不唯一+协议服务商用于在支付宝智能设备中心创建支持的设备型号+协议服务商指定
        /// </summary>
        [JsonPropertyName("model_list")]
        public List<IotDeviceModel> ModelList { get; set; }

        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [JsonPropertyName("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }
    }
}
