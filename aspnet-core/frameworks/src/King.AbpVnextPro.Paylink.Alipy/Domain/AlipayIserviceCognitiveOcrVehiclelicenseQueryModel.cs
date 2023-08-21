﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehiclelicenseQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehiclelicenseQueryModel : AlipayObject
    {
        /// <summary>
        /// 行驶证图片base64加密后内容，大小限制在1.5M
        /// </summary>
        [JsonPropertyName("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// face: 行驶证正面 back: 行驶证副页 缺省值是：face
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}
