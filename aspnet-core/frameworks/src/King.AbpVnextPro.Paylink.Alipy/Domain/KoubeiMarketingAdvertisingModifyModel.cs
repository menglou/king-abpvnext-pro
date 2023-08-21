﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingAdvertisingModifyModel Data Structure.
    /// </summary>
    public class KoubeiMarketingAdvertisingModifyModel : AlipayObject
    {
        /// <summary>
        /// 行为地址。用户点击广告后，跳转URL地址, 协议必须为HTTPS。广告类型为PIC时，需要设置该值。
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 广告ID,唯一标识一条广告
        /// </summary>
        [JsonPropertyName("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// 广告内容，目前只支持图片类型，则传入图片ID标识，如何获取图片ID参考图片上传接口：alipay.offline.material.image.upload，图片尺寸为1242px＊290px。
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 投放广告结束时间，使用标准时间格式：yyyy-MM-dd HH:mm:ss，如果不设置，默认投放时间一个月
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 目前传入广告类型为图片，该字段可以先忽略。
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 投放广告开始时间，使用标准时间格式：yyyy-MM-dd HH:mm:ss，如果不设置，默认投放时间一个月
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
