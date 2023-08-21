﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CaseInfoCode Data Structure.
    /// </summary>
    public class CaseInfoCode : AlipayObject
    {
        /// <summary>
        /// 情报代码，具体见《案件情报类型代码V1》
        /// </summary>
        [JsonPropertyName("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 情报描述信息
        /// </summary>
        [JsonPropertyName("info_code_desc")]
        public string InfoCodeDesc { get; set; }
    }
}
