﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ChildCertInfo Data Structure.
    /// </summary>
    public class ChildCertInfo : AlipayObject
    {
        /// <summary>
        /// 儿童业务id
        /// </summary>
        [JsonPropertyName("child_id")]
        public string ChildId { get; set; }

        /// <summary>
        /// 小宝账户跳转链接
        /// </summary>
        [JsonPropertyName("url")]
        public NextUrl Url { get; set; }
    }
}
