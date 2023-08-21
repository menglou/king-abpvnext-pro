﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 已废弃
        /// </summary>
        [JsonPropertyName("bin_url")]
        public string BinUrl { get; set; }

        /// <summary>
        /// 模型bin文件的下载地址
        /// </summary>
        [JsonPropertyName("bin_urls")]
        public List<string> BinUrls { get; set; }

        /// <summary>
        /// tfjs端模型json文件下载url
        /// </summary>
        [JsonPropertyName("model_json_url")]
        public string ModelJsonUrl { get; set; }
    }
}
