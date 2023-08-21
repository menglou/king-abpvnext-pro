﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoLicenseOcrIdentifyModel Data Structure.
    /// </summary>
    public class AlipayEcoLicenseOcrIdentifyModel : AlipayObject
    {
        /// <summary>
        /// 图片字节byte[]经过base64处理的字符串
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
