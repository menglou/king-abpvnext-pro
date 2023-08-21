﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotDevicelistCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDevicelistCreateModel : AlipayObject
    {
        /// <summary>
        /// 设备对象列表+不唯一+用于批量创建设备记录+协议服务商指定+0个或多个设备对象列表，单次调用传入设备对象个数不能超过200
        /// </summary>
        [JsonPropertyName("device_list")]
        public List<IotDevice> DeviceList { get; set; }

        /// <summary>
        /// 设备个性化信息列表+不唯一+用于设置设备的用户定制化信息+协议服务商指定
        /// </summary>
        [JsonPropertyName("device_personal_info_list")]
        public List<IotDevicePersonalInfo> DevicePersonalInfoList { get; set; }

        /// <summary>
        /// 协议服务商id+唯一+指定操作数据归属于哪个协议服务商+协议服务商接入时由支付宝统一分配
        /// </summary>
        [JsonPropertyName("protocol_supplier_id")]
        public string ProtocolSupplierId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
