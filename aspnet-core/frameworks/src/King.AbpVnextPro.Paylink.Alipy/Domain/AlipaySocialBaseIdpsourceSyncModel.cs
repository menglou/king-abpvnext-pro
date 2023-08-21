﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySocialBaseIdpsourceSyncModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseIdpsourceSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据内容为json格式的字符串，要求数据内容所有字段平铺，不支持复杂数据结构，时间类型请统一使用unix毫秒时间戳。
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 能唯一标识一份外部数据的名称，确定后不可变更，不可重复
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
