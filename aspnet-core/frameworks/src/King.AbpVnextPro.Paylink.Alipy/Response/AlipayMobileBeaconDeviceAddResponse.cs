﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceAddResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 请求操作成功与否，200为成功
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 请求的处理结果
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
