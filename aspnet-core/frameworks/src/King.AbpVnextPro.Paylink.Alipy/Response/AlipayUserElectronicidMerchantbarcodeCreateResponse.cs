﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserElectronicidMerchantbarcodeCreateResponse.
    /// </summary>
    public class AlipayUserElectronicidMerchantbarcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 二维码码串
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 二维码图片链接
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
