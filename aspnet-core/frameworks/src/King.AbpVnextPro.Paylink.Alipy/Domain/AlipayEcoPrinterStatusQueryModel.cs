﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoPrinterStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoPrinterStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonPropertyName("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }
    }
}
