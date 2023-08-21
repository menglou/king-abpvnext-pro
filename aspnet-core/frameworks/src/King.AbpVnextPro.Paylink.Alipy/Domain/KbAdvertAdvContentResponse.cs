﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertAdvContentResponse Data Structure.
    /// </summary>
    public class KbAdvertAdvContentResponse : AlipayObject
    {
        /// <summary>
        /// 二维码类型的内容模型（当content_type为codec时，返回该模型）
        /// </summary>
        [JsonPropertyName("content_codec")]
        public KbAdvertContentCodec ContentCodec { get; set; }

        /// <summary>
        /// 口令红包类型的内容模型（当content_type为passwordRed时，返回该模型）
        /// </summary>
        [JsonPropertyName("content_password")]
        public KbAdvertContentPassword ContentPassword { get; set; }

        /// <summary>
        /// 吱口令类型的内容模型（当content_type为shareCode时，返回该模型）
        /// </summary>
        [JsonPropertyName("content_share_code")]
        public List<KbAdvertContentShareCode> ContentShareCode { get; set; }

        /// <summary>
        /// 短链接类型的内容模型（当content_type为shortLink时，返回该模型）
        /// </summary>
        [JsonPropertyName("content_short_link")]
        public KbAdvertContentShortLink ContentShortLink { get; set; }

        /// <summary>
        /// 广告内容类型；  shortLink：短链接；  codec：二维码；  passwordRed：口令红包；  shareCode：吱口令；
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }
    }
}
