﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// NotaryFileVO Data Structure.
    /// </summary>
    public class NotaryFileVO : AlipayObject
    {
        /// <summary>
        /// 文件http地址
        /// </summary>
        [JsonPropertyName("file_addr")]
        public string FileAddr { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 用于标识某个文件
        /// </summary>
        [JsonPropertyName("file_uniq_id")]
        public string FileUniqId { get; set; }
    }
}
