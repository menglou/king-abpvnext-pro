﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsDataAutodamageImageUploadResponse.
    /// </summary>
    public class AlipayInsDataAutodamageImageUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 图像文件在oss存储上的路径
        /// </summary>
        [JsonPropertyName("image_path")]
        public string ImagePath { get; set; }
    }
}
