﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CraftsmanWorkCreateOpenModel Data Structure.
    /// </summary>
    public class CraftsmanWorkCreateOpenModel : AlipayObject
    {
        /// <summary>
        /// 视频资源必传，视频时长，单位(秒)
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 媒体资源id（通过 alipay.offline.material.image.upload 接口上传图片获取的资源id）。图片上限最大5M,支持bmp,png,jpeg,jpg,gif格式的图片。视频上限最大50M,支持MP4格式。
        /// </summary>
        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 媒体类型。仅支持图片/视频格式，图片类型时传入PICTURE；视频类型时传入VIDEO
        /// </summary>
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 外部作品id,isv的appId+外部作品id全局唯一
        /// </summary>
        [JsonPropertyName("out_work_id")]
        public string OutWorkId { get; set; }

        /// <summary>
        /// 作品标题，上限10个字。
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
