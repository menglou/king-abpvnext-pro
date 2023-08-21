﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppDfsfasDeQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppDfsfasDeQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("desd")]
        public string Desd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("desdde")]
        public string Desdde { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("desf")]
        public string Desf { get; set; }
    }
}
