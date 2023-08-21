﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PageVisitDataResponse Data Structure.
    /// </summary>
    public class PageVisitDataResponse : AlipayObject
    {
        /// <summary>
        /// 页面的访问次数
        /// </summary>
        [JsonPropertyName("page_pv")]
        public long PagePv { get; set; }

        /// <summary>
        /// 页面的访问人数
        /// </summary>
        [JsonPropertyName("page_uv")]
        public long PageUv { get; set; }

        /// <summary>
        /// 小程序的页面地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
