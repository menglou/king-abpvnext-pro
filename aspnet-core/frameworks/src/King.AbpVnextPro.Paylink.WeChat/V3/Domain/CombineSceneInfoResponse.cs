﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Domain
{
    /// <summary>
    /// 合单下单支付场景描述
    /// </summary>       
    public class CombineSceneInfoResponse : WeChatPayObject
    {
        /// <summary>
        /// 商户端设备号
        /// </summary>
        /// <remarks>
        /// 终端设备号（门店号或收银设备ID）。
        /// 特殊规则：长度最小7个字节
        /// <para>示例值：POS1:1</para>
        /// </remarks>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}
