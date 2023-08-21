﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// Function Data Structure.
    /// </summary>
    public class Function : AlipayObject
    {
        /// <summary>
        /// 功能点id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 功能点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
