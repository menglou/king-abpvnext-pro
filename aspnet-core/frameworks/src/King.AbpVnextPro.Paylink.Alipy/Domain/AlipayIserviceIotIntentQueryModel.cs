﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceIotIntentQueryModel : AlipayObject
    {
        /// <summary>
        /// iot入参
        /// </summary>
        [JsonPropertyName("iot_request")]
        public IntentQueryRequest IotRequest { get; set; }
    }
}
