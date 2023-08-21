﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataPrinterStatusGetModel Data Structure.
    /// </summary>
    public class AlipayDataPrinterStatusGetModel : AlipayObject
    {
        /// <summary>
        /// 应用token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用秘钥
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("device_sn")]
        public string DeviceSn { get; set; }
    }
}
