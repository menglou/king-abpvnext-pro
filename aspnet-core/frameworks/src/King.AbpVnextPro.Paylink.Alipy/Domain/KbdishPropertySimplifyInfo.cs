﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbdishPropertySimplifyInfo Data Structure.
    /// </summary>
    public class KbdishPropertySimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 属性明细
        /// </summary>
        [JsonPropertyName("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 属性组名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
