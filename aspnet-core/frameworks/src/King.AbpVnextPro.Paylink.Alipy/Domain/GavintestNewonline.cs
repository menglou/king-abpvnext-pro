﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// GavintestNewonline Data Structure.
    /// </summary>
    public class GavintestNewonline : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("dem")]
        public List<string> Dem { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("string")]
        public GavintestNewLeveaOne String { get; set; }
    }
}
