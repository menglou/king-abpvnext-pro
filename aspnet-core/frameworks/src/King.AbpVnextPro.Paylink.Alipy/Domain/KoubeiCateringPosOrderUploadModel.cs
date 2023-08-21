﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosOrderUploadModel : AlipayObject
    {
        /// <summary>
        /// 设备商回流的设备信息列表
        /// </summary>
        [JsonPropertyName("pos_device_infos")]
        public List<PosDeviceInfoVO> PosDeviceInfos { get; set; }

        /// <summary>
        /// 回流pos订单信息列表
        /// </summary>
        [JsonPropertyName("pos_order_infos")]
        public List<PosOrderInfoVO> PosOrderInfos { get; set; }

        /// <summary>
        /// source_type+pos订单设备信息来源类型枚举+(isv回流数据: ISV, 设备商数据: MEMA)
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }
    }
}
