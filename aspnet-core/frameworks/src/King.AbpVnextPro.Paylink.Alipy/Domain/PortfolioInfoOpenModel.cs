﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PortfolioInfoOpenModel Data Structure.
    /// </summary>
    public class PortfolioInfoOpenModel : AlipayObject
    {
        /// <summary>
        /// 头图素材id
        /// </summary>
        [JsonPropertyName("cover_image_id")]
        public string CoverImageId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举（PICTURE/VIDEO）
        /// </summary>
        [JsonPropertyName("cover_image_type")]
        public string CoverImageType { get; set; }

        /// <summary>
        /// 头图链接
        /// </summary>
        [JsonPropertyName("cover_image_url")]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [JsonPropertyName("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [JsonPropertyName("portfolio_title")]
        public string PortfolioTitle { get; set; }
    }
}
