﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockDesensitiveQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockDesensitiveQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("test_field_converter")]
        public string TestFieldConverter { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("test_fields_converter")]
        public List<string> TestFieldsConverter { get; set; }
    }
}
