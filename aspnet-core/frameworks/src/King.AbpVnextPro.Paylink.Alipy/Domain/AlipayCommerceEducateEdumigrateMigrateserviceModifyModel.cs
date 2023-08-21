﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceEducateEdumigrateMigrateserviceModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateEdumigrateMigrateserviceModifyModel : AlipayObject
    {
        /// <summary>
        /// 调用的服务名称 操作类型 + 具体服务名称
        /// </summary>
        [JsonPropertyName("handler")]
        public string Handler { get; set; }

        /// <summary>
        /// 迁移服务的具体参数 JSON结构
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }
    }
}
