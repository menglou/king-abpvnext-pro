﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MediaContentList Data Structure.
    /// </summary>
    public class MediaContentList : AlipayObject
    {
        /// <summary>
        /// 业务标识。  1：身份证正面照片；  2：身份证背面照片；  3：行驶证正页正面照片；  4：行驶证副页正面照片；  5：车头照片
        /// </summary>
        [JsonPropertyName("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 资料base64值
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 媒体类型。  1：jpg图片；  2：png图片；  3：mp4视频
        /// </summary>
        [JsonPropertyName("media_type")]
        public long MediaType { get; set; }
    }
}
