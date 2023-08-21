﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SubPackage Data Structure.
    /// </summary>
    public class SubPackage : AlipayObject
    {
        /// <summary>
        /// 构建结果地址
        /// </summary>
        [JsonPropertyName("build_package_url")]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建结果地址
        /// </summary>
        [JsonPropertyName("new_build_package_url")]
        public string NewBuildPackageUrl { get; set; }

        /// <summary>
        /// 分包路径
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// 源码地址
        /// </summary>
        [JsonPropertyName("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 分包的类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
