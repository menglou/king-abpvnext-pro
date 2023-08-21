﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CategoryLevelInfo Data Structure.
    /// </summary>
    public class CategoryLevelInfo : AlipayObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类级别
        /// </summary>
        [JsonPropertyName("category_level")]
        public long CategoryLevel { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }
    }
}
