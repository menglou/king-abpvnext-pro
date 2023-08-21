﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AlipayObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonPropertyName("cds")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }
    }
}
